using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBusinessRegion
    {
        public AgentBusinessRegion()
        {
            Agents = new HashSet<Agent>();
        }

        public int BusinessRegionId { get; set; }
        public string BusinessRegionName { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
