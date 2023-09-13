using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffDiscount
    {
        public TariffDiscount()
        {
            KcrIssues = new HashSet<KcrIssue>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
        }

        public int TariffId { get; set; }
        public int SectionId { get; set; }
        public int DiscountId { get; set; }
        public int TariffDiscountId { get; set; }
        public int? UseLimit { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
    }
}
