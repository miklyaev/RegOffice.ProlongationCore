using ProlongationService.Containers;
using RegOffice.DataModel;
using RegOffice.DataModel.Model;
using RegOffice.General.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Code
{
    public class Repository : IRepository
    {
        private readonly IDataEngine _dataEngine;

        public Repository(IDataEngine dataEngine)
        {
            _dataEngine = dataEngine;
        }

        public List<ProductProlongationData> ProlongationDataLinq(int agentId, int[] productTypeIds)
        {
            var sixMonthAgo = DateTime.Now.AddMonths(-6);
            var minDate = DateTime.MinValue;
            var steps = new[] { (int)StepTypeInfo.Locked, (int)StepTypeInfo.Revoked, (int)StepTypeInfo.Replaced };
            var DbF = Microsoft.EntityFrameworkCore.EF.Functions;
            var offices = _dataEngine.DataModel.Offices.Where(x => x.AgentId == agentId && x.OffTime == null).Select(x => x.OfficeId).ToArray();

            var products = _dataEngine.DataModel.Products.Where(x =>
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
                join ct in _dataEngine.DataModel.ContractTariffs on pr.ContractId equals ct.ContractId
                from pt in _dataEngine.DataModel.ProductTariffs.Where(pt => pt.ContractTariffId == ct.ContractTariffId).DefaultIfEmpty()
                from ta in _dataEngine.DataModel.TariffAttributes.Where(ta => ta.TariffId == ct.TariffId && ta.AttributeId == (int)TariffAttributeInfo.Transaction).DefaultIfEmpty()
                from pp in _dataEngine.DataModel.ProductPeoples.Where(pp => pp.ProductId == pr.ProductId && pp.OffTime == null).DefaultIfEmpty()
                from k in _dataEngine.DataModel.Keys.Where(k => k.KeyId == pp.KeyId).DefaultIfEmpty()
                from cert in _dataEngine.DataModel.Certificates.Where(cert => cert.CertificateId == k.CertificateId).DefaultIfEmpty()
                from ctExt in _dataEngine.DataModel.ContractTariffExtensions.Where(ext => ct.ContractTariffId == ext.ExtensionId).DefaultIfEmpty()

                where
                    ta == null &&
                    ct.EndDate > sixMonthAgo &&
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
                    TariffInitialDate = EntityFunctions.TruncateTime(ctsBase.TariffInitialDate),
                    TariffEndDate = EntityFunctions.TruncateTime(ctsBase.TariffEndDate),
                    CertificateInitialDate = EntityFunctions.TruncateTime(cts.FirstOrDefault().CertificateInitialDate),
                    CertificateEndDate = EntityFunctions.TruncateTime(cts.FirstOrDefault().CertificateEndDate),
                    TotalSum = cts.Sum(x => x.TotalSum),
                }).Distinct().ToList();

            return (from q in query
                    from psd in _dataEngine.DataModel.ProlongationShortData.Where(psd =>
                        psd.ProductId == q.ProductId &&
                        psd.AbonentId == q.AbonentId &&
                        psd.ContractId == q.ContractId &&
                        (psd.TariffEndDate ?? minDate) == (q.TariffEndDate ?? minDate) &&
                        (psd.CertificateEndDate ?? minDate) == (q.CertificateEndDate ?? minDate) &&
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

    }
}
