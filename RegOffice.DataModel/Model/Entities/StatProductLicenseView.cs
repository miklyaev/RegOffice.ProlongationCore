using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class StatProductLicenseView
    {
        public double? Y { get; set; }
        public double? M { get; set; }
        public string AgentName { get; set; }
        public long? NewLicense { get; set; }
        public long? ExtLicense { get; set; }
        public long? NewLicenseAr { get; set; }
        public long? ExtLicenseAr { get; set; }
        public string ProductTypeName { get; set; }
        public string LicenseTypeName { get; set; }
        public string Registrator { get; set; }
    }
}
