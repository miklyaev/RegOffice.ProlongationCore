using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Permission
    {
        public Permission()
        {
            KeyPermissions = new HashSet<KeyPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int TypeId { get; set; }

        public virtual PermissionType Type { get; set; }
        public virtual ICollection<KeyPermission> KeyPermissions { get; set; }
    }
}
