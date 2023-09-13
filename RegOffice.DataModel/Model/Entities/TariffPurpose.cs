using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffPurpose
    {
        public TariffPurpose()
        {
            Tariffs = new HashSet<Tariff>();
        }

        public int Id { get; set; }
        public string PurposeName { get; set; }

        public virtual ICollection<Tariff> Tariffs { get; set; }
    }
}
