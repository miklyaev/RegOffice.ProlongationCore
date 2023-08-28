using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AgentRegionRating
    {
        public int? AgentId { get; set; }
        public int? RegionId { get; set; }
        public long? Count { get; set; }
    }
}
