using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Agents
    {
        public Agents()
        {
            AgentRoles = new HashSet<AgentRoles>();
            Users = new HashSet<Users>();
        }

        public int AgentId { get; set; }
        public int AgentLevelOption { get; set; }

        public virtual AgentLevelTypes AgentLevelOptionNavigation { get; set; }
        public virtual ICollection<AgentRoles> AgentRoles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
