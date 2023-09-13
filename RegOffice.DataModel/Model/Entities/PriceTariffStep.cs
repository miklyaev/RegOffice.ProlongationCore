using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceTariffStep
    {
        public int TariffId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public int? UserId { get; set; }
        public int SectionId { get; set; }

        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Step Step { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual User User { get; set; }
    }
}
