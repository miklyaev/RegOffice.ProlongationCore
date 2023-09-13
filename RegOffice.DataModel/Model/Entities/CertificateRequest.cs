using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateRequest
    {
        public CertificateRequest()
        {
            CertificateRequestSteps = new HashSet<CertificateRequestStep>();
        }

        public int CertificateRequestId { get; set; }
        public Guid CertificateRequestGuid { get; set; }
        public int? CertificateId { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public string PublicKey { get; set; }
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public int? CertRequestId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateRequestStep> CertificateRequestSteps { get; set; }
    }
}
