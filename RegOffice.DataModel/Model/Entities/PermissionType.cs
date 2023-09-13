using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            Permissions = new HashSet<Permission>();
        }

        public int PermissionTypeId { get; set; }
        public string PermissionTypeName { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
