using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffDiscountRule
    {
        public int RuleId { get; set; }
        public int TariffDiscountId { get; set; }
        public int SectionId { get; set; }
        public int TariffId { get; set; }

        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual TariffDiscount TariffDiscount { get; set; }
    }
}
