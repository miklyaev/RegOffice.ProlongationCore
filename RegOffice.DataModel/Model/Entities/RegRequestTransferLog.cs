using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestTransferLog
    {
        public int RegRequestTransferId { get; set; }
        public int RegRequestId { get; set; }
        public DateTime LogTime { get; set; }
        public int OfficeId { get; set; }
        public int PreviousOfficeId { get; set; }
        public int UserId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Office PreviousOffice { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual User User { get; set; }
    }
}
