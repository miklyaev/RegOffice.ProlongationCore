using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceTariff
    {
        public PriceTariff()
        {
            ContractTariffs = new HashSet<ContractTariff>();
            KcrIssues = new HashSet<KcrIssue>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }

        public int TariffId { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public DateTime? EndTime { get; set; }
        public string RegisteredName { get; set; }
        public int SectionId { get; set; }
        public bool? Displayed { get; set; }
        public string Article { get; set; }
        public Guid PriceTariffId { get; set; }
        public string Note { get; set; }
        public string ShortNote { get; set; }
        public string MarketingName { get; set; }

        public virtual PriceSection Section { get; set; }
        public virtual Step Step { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
