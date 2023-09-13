using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LicenseType
    {
        public LicenseType()
        {
            LicensePools = new HashSet<LicensePool>();
            Licenses = new HashSet<License>();
        }

        public int LicenseTypeId { get; set; }
        public string LicenseTypeName { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual ICollection<LicensePool> LicensePools { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
    }
}
