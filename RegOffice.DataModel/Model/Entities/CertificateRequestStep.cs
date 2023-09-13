using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateRequestStep
    {
        public int CertificateRequestId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public int? NextStepId { get; set; }
        public string ErrorMsg { get; set; }
        public int? PreviousStepId { get; set; }

        public virtual CertificateRequest CertificateRequest { get; set; }
        public virtual Step NextStep { get; set; }
        public virtual Step PreviousStep { get; set; }
        public virtual Step Step { get; set; }
    }
}
