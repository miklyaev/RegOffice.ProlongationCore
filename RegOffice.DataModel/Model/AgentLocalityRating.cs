using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AgentLocalityRating
    {
        public int? AgentId { get; set; }
        public string Locality { get; set; }
        public int? RegionId { get; set; }
        public long? Count { get; set; }
        public int? LevelId { get; set; }
    }
}
