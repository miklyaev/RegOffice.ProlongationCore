using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdDeviceType
    {
        public OfdDeviceType()
        {
            OfdDevices = new HashSet<OfdDevice>();
        }

        public int OfdDeviceTypeId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<OfdDevice> OfdDevices { get; set; }
    }
}
