using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Contract
    {
        public Contract()
        {
            Agents = new HashSet<Agent>();
            ContractLicenses = new HashSet<ContractLicense>();
            ContractSteps = new HashSet<ContractStep>();
            ContractTariffs = new HashSet<ContractTariff>();
            Products = new HashSet<Product>();
            ProlongationShortDatas = new HashSet<ProlongationShortDatum>();
        }

        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public int AbonentId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int ContractTypeId { get; set; }
        public int OfficeId { get; set; }
        public int? UserId { get; set; }
        public DateTime StartDate { get; set; }
        public int StepId { get; set; }
        public string StepReason { get; set; }
        public int? TariffZoneId { get; set; }
        public int? CompanyGroupId { get; set; }
        public Guid ContractGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual CompanyGroup CompanyGroup { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual TariffZone TariffZone { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<ContractLicense> ContractLicenses { get; set; }
        public virtual ICollection<ContractStep> ContractSteps { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProlongationShortDatum> ProlongationShortDatas { get; set; }
    }
}
