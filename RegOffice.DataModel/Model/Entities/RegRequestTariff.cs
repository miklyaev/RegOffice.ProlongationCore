using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestTariff
    {
        public int RegRequestId { get; set; }
        public int TariffId { get; set; }
        public int Number { get; set; }
        public int? SectionId { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? Price { get; set; }

        public virtual PriceTariff PriceTariff { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
