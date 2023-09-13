using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffLimit
    {
        public int TariffId { get; set; }
        public int LimitId { get; set; }
        public string LimitValue { get; set; }

        public virtual Limit Limit { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
