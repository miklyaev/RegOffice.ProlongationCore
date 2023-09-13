using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SkziLicenseType
    {
        public SkziLicenseType()
        {
            SkziLicenses = new HashSet<SkziLicense>();
        }

        public int LicenceTypeId { get; set; }
        public string LicenseTypeName { get; set; }

        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
