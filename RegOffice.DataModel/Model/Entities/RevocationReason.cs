using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RevocationReason
    {
        public RevocationReason()
        {
            CertificateRevocations = new HashSet<CertificateRevocation>();
            CertificateSteps = new HashSet<CertificateStep>();
        }

        public int ReasonId { get; set; }
        public string ReasonDescription { get; set; }

        public virtual ICollection<CertificateRevocation> CertificateRevocations { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
    }
}
