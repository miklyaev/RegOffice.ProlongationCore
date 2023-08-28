using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class LicenseInProduct
    {
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? LicenseId { get; set; }
        public int? LicenseTypeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
