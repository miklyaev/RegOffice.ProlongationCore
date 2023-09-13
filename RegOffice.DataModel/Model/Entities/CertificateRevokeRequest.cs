using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateRevokeRequest
    {
        public CertificateRevokeRequest()
        {
            CertificateRevokeHistories = new HashSet<CertificateRevokeHistory>();
        }

        public int CertificateRevokeRequestId { get; set; }
        public int CertificateId { get; set; }
        public int? StepId { get; set; }
        public string Comment { get; set; }
        public DateTime CreationTime { get; set; }
        public int FileId { get; set; }
        public DateTime? BlockedTime { get; set; }
        public int? StepBeforeBlock { get; set; }
        public bool Is1cEtpPartner { get; set; }
        public int? Executor { get; set; }
        public bool? IsShowEmploeeUc { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateRevokeHistory> CertificateRevokeHistories { get; set; }
    }
}
