using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssTariff
    {
        public int DssId { get; set; }
        public int TariffId { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
