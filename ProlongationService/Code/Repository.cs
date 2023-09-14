using Microsoft.EntityFrameworkCore;
using ProlongationService.Containers;
using RegOffice.DataModel.Model;
using RegOffice.DataModel.Model.Entities;
using RegOffice.General.Enums;
using RegOffice.General.Models;
//using ProductProlongationData = RegOffice.DataModel.Model.ProductProlongationData;

namespace ProlongationService.Code
{
    public class Repository : IRepository, IDisposable
    {
        private readonly PostgreeSqlContext _context;

        public Repository(IDbContextFactory<PostgreeSqlContext> contextFactory)
        {
            _context = contextFactory.CreateDbContext();            
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public PostgreeSqlContext GetContext()
        {
            return _context;
        }
        public List<ProlongationShortDatum> ProlongationDataLinq(int agentId, int[] productTypeIds)
        {
            var sixMonthAgoDt = DateTime.Now.AddMonths(-6);
            //var minDate = DateTime.MinValue;
            //var steps = new[] { (int)StepTypeInfo.Locked, (int)StepTypeInfo.Revoked, (int)StepTypeInfo.Replaced };
            string strProductTypeIds = string.Join(",", productTypeIds.Select(x => x));

            string query = $@"select 
            0 as prolongation_id
            , t2.product_id
            , t2.abonent_id
            , t2.contract_id
            , t2.registration_number
            , t2.TariffInitialDate as tariff_initial_date
            , t2.TotalSum as total_sum
            , t2.TariffEndDate as tariff_end_date
            , t2.CertificateInitialDate as certificate_initial_date
            , t2.CertificateEndDate as certificate_end_date            
            , false as no_dispatch
            , null as reason_id
            , ''::varchar as comment
            , false as ignore_dispatch
            , CURRENT_DATE as transfer_date
            from
            (
            select
            t.product_id
            , t.abonent_id
            , t.contract_id
            , t.registration_number
            , t.initial_date as TariffInitialDate
            , sum(t.sum) over(partition by t.product_id, t.abonent_id, t.contract_id, t.registration_number) as TotalSum
            , row_number() over(partition by t.product_id, t.abonent_id, t.contract_id, t.registration_number) as n
            , t.TariffEndDate
            , t.initial_time as CertificateInitialDate
            , t.end_time as CertificateEndDate
            , t.isBaseLicence
            from 
            (
            select
            rp.product_id 
            , rp.abonent_id
            , rp.contract_id
            , rp.registration_number
            , max(rct.end_date) over(partition by rp.product_id, rp.abonent_id, rp.contract_id, rp.registration_number order by rct.end_date desc) as TariffEndDate
            , rct.sum
            , rct.initial_date
            , rc.initial_time
            , rc.end_time
            , case when ext.extension_id is null then true else false END as isBaseLicence

            from ro_product rp 
            join ro_contract_tariff rct on rct.contract_id = rp.contract_id
            left join ro_product_tariff rpt on rpt.contract_tariff_id = rct.contract_tariff_id
            left join ro_tariff_attribute rta on rta.tariff_id = rct.tariff_id and rta.attribute_id = 29
            left join ro_product_person rpp on rpp.product_id = rp.product_id and rpp.off_time is null 
            left join ro_key k on k.key_id = rpp.key_id
            left join ro_certificate rc on rc.certificate_id = k.certificate_id
            left join ro_contract_tariff_extension ext on ext.contract_tariff_id = rct.contract_tariff_id
            where
            rta.tariff_attribute_id is null
            and ext.contract_tariff_id is null
            and rct.end_date > '{sixMonthAgoDt.ToString("yyyy-MM-dd")}'
            and rct.step_id not in (4, 55, 56)
            and (rpp.product_type_id in ({strProductTypeIds}) or rpp.product_type_id = 20)
            and (rpt.contract_tariff_id is null and rp.proxy_agent_id is null or rpt.product_id = rp.product_id )
            and rp.office_id in
	            (
	            select ro.office_id
	            from ro_office ro 
	            where ro.agent_id = {agentId} and ro.off_time is null
	            )
            and rp.product_type_id in ({strProductTypeIds})
            and not exists
	            (
	            select rs.service_id
	            from ro_service rs
	            join ro_office ro2 on ro2.office_id = rp.office_id 
	            where rs.product_id = rp.product_id
	            and rs.service_type_id = 15
	            )
	
            ) t
            where t.isBaseLicence = true
            ) t2

            where t2.n = 1";

            return  _context.ProlongationShortDatas.FromSqlRaw(query).ToList();
        }

        public List<ProlongationShortDatum> GetOutdatedProlongationData()
        {
            var splitDate = DateTime.Now.AddMonths(-6);         
            return _context.ProlongationShortDatas.Where(p => p.TariffEndDate < splitDate && p.CertificateEndDate < splitDate).ToList();
        }

        public List<ProlongationShortDatum> GetUnactiveProlongationData()
        {
            return (from prolongationShortData in _context.ProlongationShortDatas
                    join service in _context.Services on prolongationShortData.ProductId equals
                        service.ProductId
                    where
                        service.ServiceTypeId == (int)ServiceTypeInfo.ProductUnactive
                    select prolongationShortData).ToList();
        }

        public List<ProlongationShortDatum> GetTransferredProlongationData()
        {
            return
                _context.ProlongationShortDatas
                    .Where(psd => psd.Product.ContractId != psd.ContractId || psd.Product.AbonentId != psd.AbonentId)
                    .ToList();
        }

        public ProlongationShortDatum AddProlongationShortDatum(ProlongationShortDatum psdInfo)
        {
            ProlongationShortDatum psdBase = new ProlongationShortDatum
            {
                AbonentId = psdInfo.AbonentId,
                ContractId = psdInfo.ContractId,
                ProductId = psdInfo.ProductId,

                TariffEndDate = psdInfo.TariffEndDate.HasValue ? psdInfo.TariffEndDate : null,
                CertificateEndDate = psdInfo.CertificateEndDate.HasValue ? psdInfo.CertificateEndDate : null,

                TotalSum = psdInfo.TotalSum,
                RegistrationNumber = psdInfo.RegistrationNumber,

                TariffInitialDate = psdInfo.TariffInitialDate.HasValue ? psdInfo.TariffInitialDate : null,
                CertificateInitialDate = psdInfo.CertificateInitialDate.HasValue ? psdInfo.CertificateInitialDate : null,
            };
            _context.ProlongationShortDatas.Add(psdBase);
            return psdBase;
        }

        public void RemoveProlongationShortDatum(ProlongationShortDatum prolongationShortDatum)
        {
            _context.ProlongationShortDatas.Remove(prolongationShortDatum);
        }

        public ProlongationShortDatum UpdateProlongationShortDatum(ProlongationShortDatum psdBase, ProlongationShortDatum psdInfo)
        {
            psdBase.AbonentId = psdInfo.AbonentId;
            psdBase.TariffEndDate = psdInfo.TariffEndDate.HasValue ? psdInfo.TariffEndDate : null;
            psdBase.CertificateEndDate = psdInfo.CertificateEndDate.HasValue ? psdInfo.CertificateEndDate : null;
            psdBase.TotalSum = psdInfo.TotalSum;
            psdBase.TariffInitialDate = psdInfo.TariffInitialDate.HasValue ? psdInfo.TariffInitialDate : null;
            psdBase.CertificateInitialDate = psdInfo.CertificateInitialDate.HasValue ? psdInfo.CertificateInitialDate : null;
            psdBase.RegistrationNumber = psdInfo.RegistrationNumber;

            if (psdBase.TariffEndDate > DateTime.Now)
            {
                psdBase.ReasonId = null;
                psdBase.Comment = null;
            }

            return psdBase;
        }

        public ProlongationShortDatum GetProlongationShortDatum(int productId, int contractId)
        {
            return _context.ProlongationShortDatas.SingleOrDefault(p => p.ProductId == productId && p.ContractId == contractId);
        }

        public List<ProlongationShortDatum> GetProlongationShortData(Guid productGuid)
        {
            return _context.ProlongationShortDatas.Where(p => p.Product.ProductGuid == productGuid).ToList();
        }

        public List<SummaryDifferenceData> GetSummaryDifference(int officeId)
        {
            var sixMonthsAgo = DateTime.Now.AddMonths(-6);
            return
                (from psd in _context.ProlongationShortDatas
                 join c in _context.Contracts on psd.ContractId equals c.ContractId

                 where
                     c.OfficeId == officeId &&
                     (psd.TariffEndDate.HasValue && psd.TariffEndDate.Value >= sixMonthsAgo
                     && (!psd.CertificateEndDate.HasValue || psd.CertificateEndDate.Value >= sixMonthsAgo))
                 select new SummaryDifferenceData
                 {
                     OfficeId = c.OfficeId,
                     ProlongationId = psd.ProlongationId,
                     TransferDate = psd.TransferDate.HasValue ? psd.TransferDate.Value : null,
                     TariffEndDate = psd.TariffEndDate.HasValue ? psd.TariffEndDate.Value : null,
                     CertificateInitialDate = psd.CertificateInitialDate.HasValue ? psd.CertificateInitialDate.Value : null,
                     CertificateEndDate = psd.CertificateEndDate.HasValue ? psd.CertificateEndDate.Value : null,
                     NoDispatch = psd.NoDispatch,
                     IgnoreDispatch = psd.IgnoreDispatch
                 }).Distinct().ToList();
        }

        public void UpdateShortDataSummary(int agentId)
        {
            var now = DateTime.Now;
            var nextMonth = DateTime.Now.AddMonths(1);

            var agent = _context.Agents.SingleOrDefault(x => x.AgentId == agentId);

            foreach (var officeId in agent.Offices.Where(x => !x.OffTime.HasValue).Select(x => x.OfficeId))
            {
                var query = GetSummaryDifference(officeId);
                var expiredInThisMonth = ExpiredInMonth(query, now);
                var expiredInNextMonth = ExpiredInMonth(query, nextMonth);
                var expired = Expired(query, now);
                var prolongateImmediate = query.Count(x => x.TransferDate.HasValue);
                var riskGroup = RiskGroup(query, now);
                var disabledDispatchCount = query.Count(x => x.IgnoreDispatch);

                var existShortDataSummary = _context.ProlongationShortDataSummaries.SingleOrDefault(x => x.OfficeId == officeId);
                if (existShortDataSummary != null)
                {
                    existShortDataSummary.ExpiredInThisMonth = expiredInThisMonth;
                    existShortDataSummary.ExpiredInNextMonth = expiredInNextMonth;
                    existShortDataSummary.Expired = expired;
                    existShortDataSummary.ProlongateImmediate = prolongateImmediate;
                    existShortDataSummary.RiskGroup = riskGroup;
                    existShortDataSummary.DisabledDispatchCount = disabledDispatchCount;
                }
                else
                {
                    _context.ProlongationShortDataSummaries.Add(new ProlongationShortDataSummary
                    {
                        OfficeId = officeId,
                        ExpiredInThisMonth = expiredInThisMonth,
                        ExpiredInNextMonth = expiredInNextMonth,
                        Expired = expired,
                        ProlongateImmediate = prolongateImmediate,
                        RiskGroup = riskGroup,
                        DisabledDispatchCount = disabledDispatchCount
                    });
                }
                _context.SaveChanges();
            }
        }

        public int ExpiredInMonth(List<SummaryDifferenceData> query, DateTime date)
        {
            var monthStart = new DateTime(date.Year, date.Month, 1);
            var monthEnd = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

            return (from q in query
                    where
                    monthStart <= (q.TariffEndDate < q.CertificateEndDate ? q.TariffEndDate : q.CertificateEndDate) &&
                    monthEnd >= (q.TariffEndDate < q.CertificateEndDate ? q.TariffEndDate : q.CertificateEndDate)
                    select q.ProlongationId
                ).Distinct().Count();
        }

        public int Expired(List<SummaryDifferenceData> query, DateTime date)
        {
            var sixMonthsAgo = date.AddMonths(-6);

            return (from q in query
                    where
                    date > (q.TariffEndDate < q.CertificateEndDate ? q.TariffEndDate : q.CertificateEndDate) &&
                    sixMonthsAgo <= (q.TariffEndDate < q.CertificateEndDate ? q.TariffEndDate : q.CertificateEndDate)
                    select q.ProlongationId
            ).Distinct().Count();
        }

        public int RiskGroup(List<SummaryDifferenceData> query, DateTime date)
        {
            var sixThreeAgo = date.AddMonths(-3);

            return (from q in query
                    where
                    q.NoDispatch &&
                    !q.IgnoreDispatch &&
                    q.TariffEndDate > date &&
                    q.CertificateInitialDate <= sixThreeAgo
                    select q.ProlongationId
            ).Distinct().Count();
        }

        public List<int> GetAbonentsIds()
        {
            var splitDate = DateTime.Now.AddDays(-90);
            return _context.ProlongationShortDatas.Where(p => (p.Product.ProductTypeId == 20 || p.TariffInitialDate.Value < splitDate) && p.IgnoreDispatch == false).Select(p => p.AbonentId).Distinct().ToList();
        }

        public List<int> GetNoDispatchAbonentsIds()
        {
            var splitDate = DateTime.Now.AddDays(-90);
            return _context.ProlongationShortDatas.Where(p => (p.Product.ProductTypeId == 20 || p.TariffInitialDate.Value < splitDate) && p.NoDispatch && p.IgnoreDispatch == false).
                Select(p => p.AbonentId).Distinct().ToList();
        }

        public Dictionary<Guid, int> GetAbonentsGuids(List<int> ids)
        {
            return _context.ProlongationShortDatas.Where(p => ids.Contains(p.AbonentId))
                .Select(p => new { p.Product.ProductGuid, p.Product.ProductTypeId })
                .Distinct()
                .ToDictionary(k => k.ProductGuid, v => v.ProductTypeId);
        }

        public List<ProlongationShortDatum> GetAbonentProlongationShortData(int id)
        {
            return _context.ProlongationShortDatas.Where(p => p.AbonentId == id).ToList();
        }

        public IEnumerable<int> GetProductAgents(int[] productTypeIds)
        {
            var highLevelAgents = new[]
            {
                (int) AgentLevelInfo.Vendor,
                (int) AgentLevelInfo.SalesCanter,
                (int) AgentLevelInfo.CompetenceCenter
            };

            return (
                    from pr in _context.Products
                    join o in _context.Offices on pr.OfficeId equals o.OfficeId
                    join ag in _context.Agents on o.AgentId equals ag.AgentId
                    where
                        !ag.OffTime.HasValue &&
                        !highLevelAgents.Contains(ag.LevelId) &&
                        productTypeIds.Contains(pr.ProductTypeId)
                    select ag.AgentId).Distinct().ToList();
        }   

    }
}
