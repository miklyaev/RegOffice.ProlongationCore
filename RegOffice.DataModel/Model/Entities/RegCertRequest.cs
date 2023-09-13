using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegCertRequest
    {
        public RegCertRequest()
        {
            RegCertRequestSteps = new HashSet<RegCertRequestStep>();
        }

        public int RegCertRequestId { get; set; }
        public int CertRequestId { get; set; }
        public int OfficeId { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public int CaId { get; set; }
        public string PublicKey { get; set; }
        public string SubjectKeyId { get; set; }
        public int CertTemplateId { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int RequestId { get; set; }
        public int WorkflowId { get; set; }
        public string PackId { get; set; }
        public int? CertificateId { get; set; }
        public string Message { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<RegCertRequestStep> RegCertRequestSteps { get; set; }
    }
}
