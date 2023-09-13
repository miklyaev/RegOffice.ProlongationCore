using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegionTimeZone
    {
        public int RegionId { get; set; }
        public TimeSpan TimeOffset { get; set; }

        public virtual Region Region { get; set; }
    }
}
