using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffType
    {
        public TariffType()
        {
            Tariffs = new HashSet<Tariff>();
        }

        public int TariffTypeId { get; set; }
        public string TariffTypeName { get; set; }

        public virtual ICollection<Tariff> Tariffs { get; set; }
    }
}
