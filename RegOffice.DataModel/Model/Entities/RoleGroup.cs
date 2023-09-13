using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RoleGroup
    {
        public RoleGroup()
        {
            Roles = new HashSet<Role>();
        }

        public int RoleGroupId { get; set; }
        public string RoleGroupName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
