using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceTrend
    {
        public int SectionId { get; set; }
        public int TariffId { get; set; }
        public DateTime InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal Price { get; set; }
        public decimal? Cost { get; set; }

        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
