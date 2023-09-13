using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Actual1cRequests
    {
        public int? RegRequestId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LicenseEndTime { get; set; }
        public string ProgramVersion { get; set; }
    }
}
