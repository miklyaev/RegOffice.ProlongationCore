using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Price
    {
        public Price()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            PriceSections = new HashSet<PriceSection>();
            TariffZones = new HashSet<TariffZone>();
        }

        public int PriceId { get; set; }
        public string PriceName { get; set; }
        public int PriceGroupId { get; set; }
        public string Article { get; set; }

        public virtual PriceGroup PriceGroup { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<PriceSection> PriceSections { get; set; }
        public virtual ICollection<TariffZone> TariffZones { get; set; }
    }
}
