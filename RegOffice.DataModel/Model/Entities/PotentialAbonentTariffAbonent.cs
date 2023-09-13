using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentTariffAbonent
    {
        public int PotentialAbonentId { get; set; }
        public int TariffId { get; set; }
        public int? Count { get; set; }

        public virtual PotentialAbonentTariff Tariff { get; set; }
    }
}
