using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentRegionRating
    {
        public int? AgentId { get; set; }
        public int? RegionId { get; set; }
        public long? Count { get; set; }
    }
}
