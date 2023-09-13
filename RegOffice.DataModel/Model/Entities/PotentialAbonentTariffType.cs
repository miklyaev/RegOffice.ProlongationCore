using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentTariffType
    {
        public PotentialAbonentTariffType()
        {
            PotentialAbonentTariffs = new HashSet<PotentialAbonentTariff>();
        }

        public int TariffTypeId { get; set; }
        public string TariffTypeName { get; set; }

        public virtual ICollection<PotentialAbonentTariff> PotentialAbonentTariffs { get; set; }
    }
}
