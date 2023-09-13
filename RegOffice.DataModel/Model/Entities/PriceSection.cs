using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceSection
    {
        public PriceSection()
        {
            ContractTariffs = new HashSet<ContractTariff>();
            InverseParentSection = new HashSet<PriceSection>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }

        public int SectionId { get; set; }
        public int PriceId { get; set; }
        public string SectionName { get; set; }
        public int? ParentSectionId { get; set; }

        public virtual PriceSection ParentSection { get; set; }
        public virtual Price Price { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<PriceSection> InverseParentSection { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
