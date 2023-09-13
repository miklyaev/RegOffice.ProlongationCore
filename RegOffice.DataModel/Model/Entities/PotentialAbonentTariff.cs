using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentTariff
    {
        public PotentialAbonentTariff()
        {
            PotentialAbonentTariffAbonents = new HashSet<PotentialAbonentTariffAbonent>();
        }

        public int TariffId { get; set; }
        public string TariffName { get; set; }
        public float Price { get; set; }
        public int TariffTypeId { get; set; }

        public virtual PotentialAbonentTariffType TariffType { get; set; }
        public virtual ICollection<PotentialAbonentTariffAbonent> PotentialAbonentTariffAbonents { get; set; }
    }
}
