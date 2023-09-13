using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Role
    {
        public Role()
        {
            NewsVisibilities = new HashSet<NewsVisibility>();
            RoleModules = new HashSet<RoleModule>();
            RoleSchemeAvailableRoles = new HashSet<RoleScheme>();
            RoleSchemeRoles = new HashSet<RoleScheme>();
            UserRoles = new HashSet<UserRole>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreationTime { get; set; }
        public int RoleGroupId { get; set; }
        public string RolePublicName { get; set; }

        public virtual RoleGroup RoleGroup { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<RoleModule> RoleModules { get; set; }
        public virtual ICollection<RoleScheme> RoleSchemeAvailableRoles { get; set; }
        public virtual ICollection<RoleScheme> RoleSchemeRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
