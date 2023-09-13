using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateRevocation
    {
        public int CertificateId { get; set; }
        public int ActionId { get; set; }
        public int? ReasonId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Note { get; set; }

        public virtual CaAction Action { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RevocationReason Reason { get; set; }
    }
}
