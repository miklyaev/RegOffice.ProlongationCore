using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProlongationShortDataSummary
    {
        public int SummaryId { get; set; }
        public int OfficeId { get; set; }
        public int? Expired { get; set; }
        public int? ExpiredInThisMonth { get; set; }
        public int? ExpiredInNextMonth { get; set; }
        public int? RiskGroup { get; set; }
        public int? ProlongateImmediate { get; set; }
        public int? DisabledDispatchCount { get; set; }

        public virtual Office Office { get; set; }
    }
}
