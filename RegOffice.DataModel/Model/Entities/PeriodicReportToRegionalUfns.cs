using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PeriodicReportToRegionalUfns
    {
        public string RecipientCode { get; set; }
        public long? CountAll { get; set; }
        public long? CountIp { get; set; }
        public long? ConCountMonth { get; set; }
        public long? IpConCountMonth { get; set; }
        public int? RegionId { get; set; }
    }
}
