using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentLevelAuc
    {
        public AgentLevelAuc()
        {
            Agents = new HashSet<Agent>();
        }

        public int LevelAucId { get; set; }
        public string LevelAucName { get; set; }
        public string LevelAucDescription { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
