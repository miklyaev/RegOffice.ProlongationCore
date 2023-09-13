using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestService
    {
        public int ServiceId { get; set; }
        public int RegRequestId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceNumber { get; set; }
        public int? UserId { get; set; }
        public int? MemberId { get; set; }

        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual User User { get; set; }
    }
}
