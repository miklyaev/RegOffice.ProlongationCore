using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaAction
    {
        public CaAction()
        {
            CertificateRevocations = new HashSet<CertificateRevocation>();
            CertificateSteps = new HashSet<CertificateStep>();
        }

        public int ActionId { get; set; }
        public string ActionDescription { get; set; }

        public virtual ICollection<CertificateRevocation> CertificateRevocations { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
    }
}
