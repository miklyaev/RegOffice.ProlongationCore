using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateServiceStep
    {
        public int CertificateServiceId { get; set; }
        public int StepId { get; set; }
        public string Message { get; set; }
        public DateTime LogTime { get; set; }
        public int CertificateServiceStepId { get; set; }

        public virtual CertificateService CertificateService { get; set; }
    }
}
