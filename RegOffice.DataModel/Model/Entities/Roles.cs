using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Roles
    {
        public Roles()
        {
            AgentRoles = new HashSet<AgentRoles>();
            DocumentRoles = new HashSet<DocumentRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AgentRoles> AgentRoles { get; set; }
        public virtual ICollection<DocumentRoles> DocumentRoles { get; set; }
    }
}
