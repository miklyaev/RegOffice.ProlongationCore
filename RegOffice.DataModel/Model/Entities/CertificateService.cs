using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateService
    {
        public CertificateService()
        {
            CertificateServiceSettings = new HashSet<CertificateServiceSetting>();
            CertificateServiceSteps = new HashSet<CertificateServiceStep>();
        }

        public int CertificateId { get; set; }
        public int ServiceTypeId { get; set; }
        public int StepId { get; set; }
        public string Message { get; set; }
        public int CertificateServiceId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateServiceSetting> CertificateServiceSettings { get; set; }
        public virtual ICollection<CertificateServiceStep> CertificateServiceSteps { get; set; }
    }
}
