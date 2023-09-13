using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateStep
    {
        public int CertificateId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public int? ActionId { get; set; }
        public int? ReasonId { get; set; }
        public DateTime? ActionStartTime { get; set; }
        public DateTime? ActionEndTime { get; set; }
        public string Message { get; set; }

        public virtual CaAction Action { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RevocationReason Reason { get; set; }
        public virtual Step Step { get; set; }
    }
}
