using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentLevel
    {
        public AgentLevel()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            Agents = new HashSet<Agent>();
            NewsVisibilities = new HashSet<NewsVisibility>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public string LevelNote { get; set; }

        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
    }
}
