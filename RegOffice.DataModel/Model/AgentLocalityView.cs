using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AgentLocalityView
    {
        public int? AgentId { get; set; }
        public string Locality { get; set; }
        public int? RegionId { get; set; }
        public long? PartnerCount { get; set; }
        public long? SaleCenterCount { get; set; }
        public int? LevelId { get; set; }
    }
}
