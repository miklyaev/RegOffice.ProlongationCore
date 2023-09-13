using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Tariff
    {
        public Tariff()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            ContractTariffs = new HashSet<ContractTariff>();
            DssTariffs = new HashSet<DssTariff>();
            ModuleTariffs = new HashSet<ModuleTariff>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffAttributes = new HashSet<TariffAttribute>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
            TariffDiscounts = new HashSet<TariffDiscount>();
            TariffLimits = new HashSet<TariffLimit>();
        }

        public int TariffId { get; set; }
        public Guid TariffGuid { get; set; }
        public string TariffName { get; set; }
        public int TariffTypeId { get; set; }
        public int TariffGroupId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Article { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PurposeId { get; set; }

        public virtual TariffPurpose Purpose { get; set; }
        public virtual TariffGroup TariffGroup { get; set; }
        public virtual TariffType TariffType { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<DssTariff> DssTariffs { get; set; }
        public virtual ICollection<ModuleTariff> ModuleTariffs { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
        public virtual ICollection<TariffLimit> TariffLimits { get; set; }
    }
}
