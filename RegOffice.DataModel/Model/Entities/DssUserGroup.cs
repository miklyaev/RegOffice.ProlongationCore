using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssUserGroup
    {
        public DssUserGroup()
        {
            DssUsers = new HashSet<DssUser>();
        }

        public int GroupId { get; set; }
        public int DssId { get; set; }
        public string GroupName { get; set; }
        public int LicenseValidity { get; set; }
        public int ValidityUnitId { get; set; }
        public DateTime? OffTime { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
    }
}
