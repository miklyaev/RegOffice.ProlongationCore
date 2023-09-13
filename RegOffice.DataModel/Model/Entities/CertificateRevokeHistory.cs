using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateRevokeHistory
    {
        public int CertificateRevokeId { get; set; }
        public string FileName { get; set; }
        public int StepId { get; set; }
        public int UserId { get; set; }
        public DateTime ChangeTime { get; set; }
        public string Comment { get; set; }
        public int CertificateRevokeHistoryId { get; set; }

        public virtual CertificateRevokeRequest CertificateRevoke { get; set; }
        public virtual User User { get; set; }
    }
}
