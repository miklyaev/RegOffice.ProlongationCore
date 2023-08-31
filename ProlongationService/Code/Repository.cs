using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProlongationService.Containers;
using RegOffice.DataModel;
using RegOffice.DataModel.Model;
using RegOffice.General.Enums;
using RegOffice.General.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<ProductProlongationData> ProlongationDataLinq(int agentId, int[] productTypeIds)
        {
            var sixMonthAgo = DateTime.Now.AddMonths(-6);
            var minDate = DateTime.MinValue;
            var steps = new[] { (int)StepTypeInfo.Locked, (int)StepTypeInfo.Revoked, (int)StepTypeInfo.Replaced };
            var offices = _context.Offices.Where(x => x.AgentId == agentId && x.OffTime == null).Select(x => x.OfficeId).ToArray();

            var products = _context.Products.Where(x =>
                offices.Contains(x.OfficeId) && productTypeIds.Contains(x.ProductTypeId) && x.Services.All(p => p.ServiceTypeId != (int)ServiceTypeInfo.ProductUnactive)).Select(x =>
                new
                {
                    x.ProductId,
                    x.ProductTypeId,
                    x.ContractId,
                    x.AbonentId,
                    x.ProxyAgentId,
                    x.RegistrationNumber
                });

            var query = (
                from pr in products
                join ct in _context.ContractTariffs on pr.ContractId equals ct.ContractId
                from pt in _context.ProductTariffs.Where(pt => pt.ContractTariffId == ct.ContractTariffId).DefaultIfEmpty()
                from ta in _context.TariffAttributes.Where(ta => ta.TariffId == ct.TariffId && ta.AttributeId == (int)TariffAttributeInfo.Transaction).DefaultIfEmpty()
                from pp in _context.ProductPeoples.Where(pp => pp.ProductId == pr.ProductId && pp.OffTime == null).DefaultIfEmpty()
                from k in _context.Keys.Where(k => k.KeyId == pp.KeyId).DefaultIfEmpty()
                from cert in _context.Certificates.Where(cert => cert.CertificateId == k.CertificateId).DefaultIfEmpty()
                from ctExt in _context.ContractTariffExtensions.Where(ext => ct.ContractTariffId == ext.ExtensionId).DefaultIfEmpty()
                let endDate = ct.EndDate.HasValue ? ct.EndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : default
                where

                    ta == null &&
                    endDate > sixMonthAgo &&
                    !steps.Contains(ct.StepId) &&
                    (productTypeIds.Contains(pp.ProductTypeId) || pr.ProductTypeId == (int)ProductTypeInfo.Sedna) &&
                    (pt == null && pr.ProxyAgentId == null || pt.ProductId == pr.ProductId)
                group new
                {
                    TariffInitialDate = ct.InitialDate,
                    TariffEndDate = ct.EndDate,
                    CertificateInitialDate = cert.InitialTime,
                    CertificateEndDate = cert.EndTime,
                    TotalSum = ct.Sum,
                    isBaseLicence = ctExt == null
                }
                    by new
                    {
                        pr.ProductId,
                        pr.AbonentId,
                        pr.RegistrationNumber,
                        ct.ContractId,
                    }
                into grp
                let cts = grp.Where(x => x.TariffEndDate == grp.Max(y => y.TariffEndDate))
                let ctsBase = grp.Where(x => x.isBaseLicence).OrderByDescending(x => x.TariffEndDate).FirstOrDefault()
                select new ProductProlongationData
                {
                    ProductId = grp.Key.ProductId,
                    AbonentId = grp.Key.AbonentId,
                    RegistrationNumber = grp.Key.RegistrationNumber,
                    ContractId = grp.Key.ContractId,
                    TariffInitialDate = ctsBase.TariffInitialDate.ToDateTime(new TimeOnly(0, 0, 0)),
                    TariffEndDate = ctsBase.TariffEndDate.HasValue ? ctsBase.TariffEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : default,
                    CertificateInitialDate = cts.FirstOrDefault() != null ? cts.FirstOrDefault().CertificateInitialDate.Date : default,
                    CertificateEndDate = cts.FirstOrDefault() != null ? cts.FirstOrDefault().CertificateEndDate.Date : default,
                    TotalSum = cts.Sum(x => x.TotalSum),
                }).Distinct().ToList();

            return (from q in query
                    from psd in _context.ProlongationShortDatas.Where(psd =>
                        psd.ProductId == q.ProductId &&
                        psd.AbonentId == q.AbonentId &&
                        psd.ContractId == q.ContractId &&
                        (psd.TariffEndDate.HasValue ? psd.TariffEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : minDate) == (q.TariffEndDate ?? minDate) &&
                        (psd.CertificateEndDate.HasValue ? psd.CertificateEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : minDate) == (q.CertificateEndDate ?? minDate) &&
                        psd.TotalSum == q.TotalSum &&
                        (psd.RegistrationNumber ?? string.Empty) == (q.RegistrationNumber ?? string.Empty)
                    ).DefaultIfEmpty()
                    where
                        psd == null
                    select new ProductProlongationData
                    {
                        ProductId = q.ProductId,
                        AbonentId = q.AbonentId,
                        RegistrationNumber = q.RegistrationNumber,
                        ContractId = q.ContractId,
                        TariffInitialDate = q.TariffInitialDate,
                        TariffEndDate = q.TariffEndDate,
                        CertificateInitialDate = q.CertificateInitialDate,
                        CertificateEndDate = q.CertificateEndDate,
                        TotalSum = q.TotalSum
                    }).Distinct().ToList();
        }

        private bool TariffCertEndDateCondition(ProlongationShortDatum p, DateTime splitDate)
        {
            DateTime? tariffEndDate = p.TariffEndDate.HasValue ? p.TariffEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null;
            DateTime? certEndDate = p.CertificateEndDate.HasValue ? p.CertificateEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null;
            return tariffEndDate < splitDate && certEndDate < splitDate;
        }
        public List<ProlongationShortDatum> GetOutdatedProlongationData()
        {
            var splitDate = DateTime.Now.AddMonths(-6);
            return _context.ProlongationShortDatas.Where(p => TariffCertEndDateCondition(p, splitDate)).ToList();
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

        public ProlongationShortDatum AddProlongationShortDatum(ProductProlongationData psdInfo)
        {
            ProlongationShortDatum psdBase = new ProlongationShortDatum
            {
                AbonentId = psdInfo.AbonentId,
                ContractId = psdInfo.ContractId,
                ProductId = psdInfo.ProductId,

                TariffEndDate = psdInfo.TariffEndDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.TariffEndDate) : null,
                CertificateEndDate = psdInfo.CertificateEndDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.CertificateEndDate) : null,

                TotalSum = psdInfo.TotalSum,
                RegistrationNumber = psdInfo.RegistrationNumber,

                TariffInitialDate = psdInfo.TariffInitialDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.TariffInitialDate) : null,
                CertificateInitialDate = psdInfo.CertificateInitialDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.CertificateInitialDate) : null,
            };
            _context.ProlongationShortDatas.Add(psdBase);
            return psdBase;
        }

        public void RemoveProlongationShortDatum(ProlongationShortDatum prolongationShortDatum)
        {
            _context.ProlongationShortDatas.Remove(prolongationShortDatum);
        }

        public ProlongationShortDatum UpdateProlongationShortDatum(ProlongationShortDatum psdBase, ProductProlongationData psdInfo)
        {
            psdBase.AbonentId = psdInfo.AbonentId;
            psdBase.TariffEndDate = psdInfo.TariffEndDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.TariffEndDate) : null;
            psdBase.CertificateEndDate = psdInfo.CertificateEndDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.CertificateEndDate) : null;
            psdBase.TotalSum = psdInfo.TotalSum;
            psdBase.TariffInitialDate = psdInfo.TariffInitialDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.TariffInitialDate) : null;
            psdBase.CertificateInitialDate = psdInfo.CertificateInitialDate.HasValue ? DateOnly.FromDateTime((DateTime)psdInfo.CertificateInitialDate) : null;
            psdBase.RegistrationNumber = psdInfo.RegistrationNumber;

            if (psdBase.TariffEndDate?.ToDateTime(new TimeOnly(0, 0, 0)) > DateTime.Now)
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
                     (psd.TariffEndDate.HasValue && psd.TariffEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) >= sixMonthsAgo
                     && (!psd.CertificateEndDate.HasValue || psd.CertificateEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) >= sixMonthsAgo))
                 select new SummaryDifferenceData
                 {
                     OfficeId = c.OfficeId,
                     ProlongationId = psd.ProlongationId,
                     TransferDate = psd.TransferDate.HasValue ? psd.TransferDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null,
                     TariffEndDate = psd.TariffEndDate.HasValue ? psd.TariffEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null,
                     CertificateInitialDate = psd.CertificateInitialDate.HasValue ? psd.CertificateInitialDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null,
                     CertificateEndDate = psd.CertificateEndDate.HasValue ? psd.CertificateEndDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) : null,
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
            return _context.ProlongationShortDatas.Where(p => (p.Product.ProductTypeId == 20 || p.TariffInitialDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) < splitDate) && p.IgnoreDispatch == false).Select(p => p.AbonentId).Distinct().ToList();
        }

        public List<int> GetNoDispatchAbonentsIds()
        {
            var splitDate = DateTime.Now.AddDays(-90);
            return _context.ProlongationShortDatas.Where(p => (p.Product.ProductTypeId == 20 || p.TariffInitialDate.Value.ToDateTime(new TimeOnly(0, 0, 0)) < splitDate) && p.NoDispatch && p.IgnoreDispatch == false).
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

        #region deprecated

        public List<ProductProlongationData> GetProductsProlongationData()
        {
            string query = @"
                            SELECT updater.product_id as ProductId,
                               updater.abonent_id as AbonentId,
                               updater.contract_id as ContractId,
                               updater.tariff_initial_date as TariffInitialDate,
                               updater.tariff_end_date as TariffEndDate,
                               updater.certificate_initial_time as CertificateInitialDate,
                               updater.certificate_end_date as CertificateEndDate,
                               updater.total_sum as TotalSum,
                               updater.waiting_days as WaitingDays,
                               updater.registration_number as RegistrationNumber
                        FROM   (SELECT p.product_id,
                               p.product_guid,
                               p.abonent_id,
                               p.registration_number,
                               ct.contract_id,
                               ct.initial_date as tariff_initial_date,
                               ct.end_date as tariff_end_date,
                               ct.waiting_days as waiting_days,
                               sum(ct.price) as total_sum,
                               date(cer.initial_time) as certificate_initial_time,
                               date(cer.end_time) as certificate_end_date
                            FROM ro_product p
                                 JOIN ro_contract_tariff ct ON ct.contract_id = p.contract_id
                                 LEFT JOIN ro_product_tariff pt ON pt.contract_tariff_id =
                                  ct.contract_tariff_id
                                 LEFT JOIN ro_tariff_attribute ta on ta.tariff_id = ct.tariff_id and
                                  ta.attribute_id = 29
                                 LEFT JOIN ro_product_person pp on pp.product_id = p.product_id and
                                  pp.off_time is null
                                 LEFT JOIN ro_key k on k.key_id = pp.key_id
                                 LEFT JOIN ro_certificate cer on cer.certificate_id = k.certificate_id
                            WHERE ta.tariff_id IS NULL AND
                                  ((pt.product_id IS NULL AND
                                  p.proxy_agent_id IS NULL) OR
                                  pt.product_id = p.product_id) AND
                                  ct.step_id <> 55 AND
                                  ct.step_id <> 4 AND
                                  p.product_type_id in (1,4) AND
                                  p.date_fixed >(NOW() - interval '6 months')                                  
                                  AND
                                  ct.end_date =
                                  (
                                    SELECT max(ct1.end_date) as last_tariff_end_time
                                    FROM ro_contract_tariff ct1
                                         LEFT JOIN ro_product_tariff pt1 ON pt1.contract_tariff_id =
                                          ct1.contract_tariff_id
                                         LEFT JOIN ro_tariff_attribute ta1 on ta1.tariff_id = ct1.tariff_id
                                          and ta1.attribute_id = 29
                                    WHERE ta1.tariff_id IS NULL AND
                                          ((pt1.product_id IS NULL AND
                                          p.proxy_agent_id IS NULL) OR
                                          pt1.product_id = p.product_id) AND
                                          ct1.step_id <> 55 AND
                                          ct1.step_id <> 4 AND
                                          ct1.contract_id = p.contract_id
                                  )
                            group by p.product_id,
                                     p.product_guid,
                                     p.abonent_id,
                                     ct.contract_id,
                                     ct.initial_date,
                                     ct.end_date,
                                     ct.waiting_days,
                                     cer.initial_time,
                                     cer.end_time) updater
                        LEFT JOIN
                          ro_prolongation_short_data psd 
                            ON psd.product_id=updater.product_id AND
                               psd.abonent_id=updater.abonent_id AND
                               psd.contract_id=updater.contract_id AND
                               psd.tariff_end_date=updater.tariff_end_date AND
                               psd.certificate_end_date=updater.certificate_end_date AND
                               psd.total_sum=updater.total_sum AND
                               psd.registration_number = updater.registration_number
                        WHERE psd.prolongation_id is null";


            FormattableString formattableString = $"{query}";
            return _context.Database.SqlQuery<ProductProlongationData>(formattableString).ToList();
        }

        public List<ProductProlongationData> GetProductsEpProlongationData()
        {
            string query = @"
SELECT updater.product_id as ProductId,
       updater.abonent_id as AbonentId,
       updater.contract_id as ContractId,
       updater.tariff_initial_date as TariffInitialDate,
       updater.tariff_end_date as TariffEndDate,
       updater.certificate_initial_time as CertificateInitialDate,
       updater.certificate_end_date as CertificateEndDate,
       updater.total_sum as TotalSum,
       updater.waiting_days as WaitingDays,
       updater.registration_number as RegistrationNumber
FROM   (SELECT p.product_id,
               p.product_guid,
               p.abonent_id,
               p.registration_number,
               ct.contract_id,
               ct.initial_date as tariff_initial_date,
               ct.end_date as tariff_end_date,
               ct.waiting_days as waiting_days,
               sum(ct.price) as total_sum,
               date(cer.initial_time) as certificate_initial_time,
               date(cer.end_time) as certificate_end_date
        FROM ro_product p
             join ro_contract_tariff ct ON ct.contract_id = p.contract_id
             join ro_contract c on c.contract_id = ct.contract_id
             join ro_product_person pp on pp.product_id = p.product_id and pp.off_time is null
             left join ro_key k on k.key_id = pp.key_id
             left join ro_certificate cer on cer.certificate_id = k.certificate_id
        WHERE ct.step_id not in (4,55) and
	    	  pp.product_type_id in (2,9,10,17) and
              p.product_type_id in (2,9,10,17) and
              c.contract_type_id in (8,9,11) and
              p.date_fixed > (now() - interval '6 months') AND
              ct.end_date =
              (
                SELECT max(ct1.end_date) as last_tariff_end_time
                FROM ro_contract_tariff ct1
                WHERE ct.step_id not in (4,55) and
                      ct1.contract_id = p.contract_id
              )
        group by p.product_id,
                 p.product_guid,
                 p.abonent_id,
                 ct.contract_id,
                 ct.initial_date,
                 ct.end_date,
                 ct.waiting_days,
                 cer.initial_time,
                 cer.end_time) updater
LEFT JOIN
  ro_prolongation_short_data psd 
    ON psd.product_id=updater.product_id AND
       psd.abonent_id=updater.abonent_id AND
       psd.contract_id=updater.contract_id AND
       psd.tariff_end_date=updater.tariff_end_date AND
       psd.certificate_end_date=updater.certificate_end_date AND
       psd.total_sum=updater.total_sum AND
       psd.registration_number = updater.registration_number
WHERE psd.prolongation_id is null";
            FormattableString formattableString = $"{query}";
            return _context.Database.SqlQuery<ProductProlongationData>(formattableString).ToList();
        }

        public List<ShortDataSummary> GetProlongationShortDataSummaryDifference()
        {
            string query = @"WITH 
                            source as (
                            SELECT o.office_id, o.agent_id, psd.*

                            FROM ro_prolongation_short_data psd
                            INNER JOIN ro_contract c on c.contract_id = psd.contract_id
                            INNER JOIN ro_office o on o.office_id = c.office_id
                            INNER JOIN ro_agent a on o.agent_id = a.agent_id

                            WHERE 
                            (psd.tariff_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                            AND psd.certificate_end_date >= CURRENT_DATE - '6 month'::INTERVAL)
                            ),
                            ExpiredInThisMonth as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ExpiredInThisMonth
                                FROM source s
	                            WHERE 
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN 
    	                            s.tariff_end_date >= date_trunc('month', current_date) 
                                    AND
                                    s.tariff_end_date <= date_trunc('month', current_date + '1 month'::INTERVAL) - '1 hour'::INTERVAL
                                ELSE 
    	                            s.certificate_end_date >= date_trunc('month', current_date)
                                    AND
                                    s.certificate_end_date <= date_trunc('month', current_date + '1 month'::INTERVAL) - '1 hour'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            ExpiredInNextMonth as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ExpiredInNextMonth
                                FROM source s
	                            WHERE 
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN 
    	                            s.tariff_end_date >= date_trunc('month', current_date + '1 month'::INTERVAL) 
                                    AND
                                    s.tariff_end_date <= date_trunc('month', current_date + '2 month'::INTERVAL) - '1 hour'::INTERVAL
                                ELSE 
    	                            s.certificate_end_date >= date_trunc('month', current_date + '1 month'::INTERVAL)
                                    AND
                                    s.certificate_end_date <= date_trunc('month', current_date + '2 month'::INTERVAL) - '1 hour'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            Expired as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as Expired
                                FROM source s
	                            WHERE 
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN 
    	                            s.tariff_end_date < CURRENT_DATE 
                                    AND
                                    s.tariff_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                                ELSE 
    	                            s.certificate_end_date < CURRENT_DATE
                                    AND
                                    s.certificate_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            ProlongateImmediate as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ProlongateImmediate
                                FROM source s
	                            WHERE 
	                            s.transfer_date IS NOT NULL
	                            GROUP BY s.office_id
                            ),
                            RiskGroup as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as RiskGroup
                                FROM source s
	                            WHERE 
	                            s.certificate_initial_date <= CURRENT_DATE - '3 month'::INTERVAL
	                            AND s.tariff_end_date > CURRENT_DATE
                                AND s.no_dispatch = '1'
                                AND s.ignore_dispatch = '0'
	                            GROUP BY s.office_id
                            ),
                            DisabledDispatchCount as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as DisabledDispatchCount
                                FROM source s
	                            WHERE 
	                            s.ignore_dispatch = '1'
	                            GROUP BY s.office_id
                            ) 

                            SELECT t.office_id as OfficeId,
                            COALESCE(t1.ExpiredInThisMonth, 0) as ExpiredInThisMonth,
                            COALESCE(t2.ExpiredInNextMonth, 0) as ExpiredInNextMonth,
                            COALESCE(t3.Expired, 0) as Expired,
                            COALESCE(t4.ProlongateImmediate, 0) as ProlongateImmediate,
                            COALESCE(t5.RiskGroup, 0) as RiskGroup,
                            COALESCE(t6.DisabledDispatchCount, 0) as DisabledDispatchCount
                            FROM source t
                            LEFT JOIN ExpiredInThisMonth t1 on t1.office_id = t.office_id
                            LEFT JOIN ExpiredInNextMonth t2 on t2.office_id = t.office_id
                            LEFT JOIN Expired t3 on t3.office_id = t.office_id
                            LEFT JOIN ProlongateImmediate t4 on t1.office_id = t.office_id
                            LEFT JOIN RiskGroup t5 on t5.office_id = t.office_id
                            LEFT JOIN DisabledDispatchCount t6 on t6.office_id = t.office_id
                            GROUP BY t.office_id,
                            t1.ExpiredInThisMonth,
                            t2.ExpiredInNextMonth,
                            t3.Expired,
                            t4.ProlongateImmediate,
                            t5.RiskGroup,
                            t6.DisabledDispatchCount
                            EXCEPT
                            select
                            p.office_id as OfficeId,
                            p.expired_in_this_month as ExpiredInThisMonth,
                            p.expired_in_next_month as ExpiredInNextMonth,
                            p.expired as Expired,
                            p.prolongate_immediate as ProlongateImmediate,
                            p.risk_group as RiskGroup,
                            p.disabled_dispatch_count as DisabledDispatchCount
                            from ro_prolongation_short_data_summary p";
            FormattableString formattableString = $"{query}";
            return _context.Database.SqlQuery<ShortDataSummary>(formattableString).ToList();
        }

        public List<ShortDataSummary> GetProlongationShortDataSummaryToRemove()
        {
            string query = @"SELECT
                            p.office_id as OfficeId,
                            p.expired_in_this_month as ExpiredInThisMonth,
                            p.expired_in_next_month as ExpiredInNextMonth,
                            p.expired as Expired,
                            p.prolongate_immediate as ProlongateImmediate,
                            p.risk_group as RiskGroup,
                            p.disabled_dispatch_count as DisabledDispatchCount
                            from ro_prolongation_short_data_summary p

                            EXCEPT

                            (WITH
                            source as (
                            SELECT o.office_id, o.agent_id, psd.*

                            FROM ro_prolongation_short_data psd
                            INNER JOIN ro_contract c on c.contract_id = psd.contract_id
                            INNER JOIN ro_office o on o.office_id = c.office_id
                            INNER JOIN ro_agent a on o.agent_id = a.agent_id

                            WHERE
                            (psd.tariff_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                            AND psd.certificate_end_date >= CURRENT_DATE - '6 month'::INTERVAL)
                            ),
                            ExpiredInThisMonth as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ExpiredInThisMonth
                                FROM source s
	                            WHERE
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN
    	                            s.tariff_end_date >= date_trunc('month', current_date)
                                    AND
                                    s.tariff_end_date <= date_trunc('month', current_date + '1 month'::INTERVAL) - '1 hour'::INTERVAL
                                ELSE
    	                            s.certificate_end_date >= date_trunc('month', current_date)
                                    AND
                                    s.certificate_end_date <= date_trunc('month', current_date + '1 month'::INTERVAL) - '1 hour'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            ExpiredInNextMonth as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ExpiredInNextMonth
                                FROM source s
	                            WHERE
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN
    	                            s.tariff_end_date >= date_trunc('month', current_date + '1 month'::INTERVAL)
                                    AND
                                    s.tariff_end_date <= date_trunc('month', current_date + '2 month'::INTERVAL) - '1 hour'::INTERVAL
                                ELSE
    	                            s.certificate_end_date >= date_trunc('month', current_date + '1 month'::INTERVAL)
                                    AND
                                    s.certificate_end_date <= date_trunc('month', current_date + '2 month'::INTERVAL) - '1 hour'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            Expired as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as Expired
                                FROM source s
	                            WHERE
	                            CASE WHEN s.tariff_end_date < s.certificate_end_date
                                THEN
    	                            s.tariff_end_date < CURRENT_DATE
                                    AND
                                    s.tariff_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                                ELSE
    	                            s.certificate_end_date < CURRENT_DATE
                                    AND
                                    s.certificate_end_date >= CURRENT_DATE - '6 month'::INTERVAL
                                END
	                            GROUP BY s.office_id
                            ),
                            ProlongateImmediate as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as ProlongateImmediate
                                FROM source s
	                            WHERE
	                            s.transfer_date IS NOT NULL
	                            GROUP BY s.office_id
                            ),
                            RiskGroup as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as RiskGroup
                                FROM source s
	                            WHERE
	                            s.certificate_initial_date <= CURRENT_DATE - '3 month'::INTERVAL
	                            AND s.tariff_end_date > CURRENT_DATE
                                AND s.no_dispatch = '1'
                                AND s.ignore_dispatch = '0'
	                            GROUP BY s.office_id
                            ),
                            DisabledDispatchCount as (
	                            SELECT s.office_id, COUNT(s.prolongation_id) as DisabledDispatchCount
                                FROM source s
	                            WHERE
	                            s.ignore_dispatch = '1'
	                            GROUP BY s.office_id
                            )

                            SELECT t.office_id as OfficeId,
                            COALESCE(t1.ExpiredInThisMonth, 0) as ExpiredInThisMonth,
                            COALESCE(t2.ExpiredInNextMonth, 0) as ExpiredInNextMonth,
                            COALESCE(t3.Expired, 0) as Expired,
                            COALESCE(t4.ProlongateImmediate, 0) as ProlongateImmediate,
                            COALESCE(t5.RiskGroup, 0) as RiskGroup,
                            COALESCE(t6.DisabledDispatchCount, 0) as DisabledDispatchCount
                            FROM source t
                            LEFT JOIN ExpiredInThisMonth t1 on t1.office_id = t.office_id
                            LEFT JOIN ExpiredInNextMonth t2 on t2.office_id = t.office_id
                            LEFT JOIN Expired t3 on t3.office_id = t.office_id
                            LEFT JOIN ProlongateImmediate t4 on t1.office_id = t.office_id
                            LEFT JOIN RiskGroup t5 on t5.office_id = t.office_id
                            LEFT JOIN DisabledDispatchCount t6 on t6.office_id = t.office_id
                            GROUP BY t.office_id,
                            t1.ExpiredInThisMonth,
                            t2.ExpiredInNextMonth,
                            t3.Expired,
                            t4.ProlongateImmediate,
                            t5.RiskGroup,
                            t6.DisabledDispatchCount)";
            FormattableString formattableString = $"{query}";
            return _context.Database.SqlQuery<ShortDataSummary>(formattableString).ToList();
        }

        #endregion

    }
}
