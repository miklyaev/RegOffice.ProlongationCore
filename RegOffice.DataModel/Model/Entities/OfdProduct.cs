using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdProduct
    {
        public int OfdProductId { get; set; }
        public int ProductId { get; set; }
        public string TariffName { get; set; }
        public int ContractTariffId { get; set; }
        public DateTime? ContractTariffInitialDate { get; set; }
        public DateTime? ContractTariffEndDate { get; set; }
        public string ContractTariffRegnum { get; set; }
        public int? ContractTariffStepId { get; set; }
        public string Pin { get; set; }
        public string SerialNumberKkt { get; set; }
        public string RegistrationNumberKkt { get; set; }
        public string ModelKkt { get; set; }
        public Guid? WalletGuid { get; set; }
        public int? FiscalAcummValidityPeriod { get; set; }
        public DateTime? FiscalAcummActivationDate { get; set; }
        public string FiscalAcummNumber { get; set; }
        public string FiscalAcummModel { get; set; }
        public DateTime? FiscalAcummEnddate { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual Product Product { get; set; }
    }
}
