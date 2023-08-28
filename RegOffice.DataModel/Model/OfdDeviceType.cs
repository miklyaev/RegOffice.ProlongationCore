using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
