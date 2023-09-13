using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestDoc
    {
        public int RegRequestId { get; set; }
        public int DocId { get; set; }
        public int? SourceId { get; set; }
        public int? MemberId { get; set; }
        public int? ConfirmedByUserId { get; set; }

        public virtual User ConfirmedByUser { get; set; }
        public virtual Doc Doc { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
