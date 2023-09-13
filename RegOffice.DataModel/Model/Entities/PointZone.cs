using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PointZone
    {
        public int PointZoneId { get; set; }
        public int PointId { get; set; }
        public int RegionId { get; set; }

        public virtual Point Point { get; set; }
        public virtual Region Region { get; set; }
    }
}
