using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateIrudRegistration
    {
        public int CertificateRegistrationId { get; set; }
        public int CertificateId { get; set; }
        public int ProductId { get; set; }
        public int SosId { get; set; }
        public int CertificateStateId { get; set; }
        public int CertificateRegistrationStepId { get; set; }
        public DateTime? RegistrationTime { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step CertificateRegistrationStep { get; set; }
        public virtual Step CertificateState { get; set; }
        public virtual Product Product { get; set; }
        public virtual Sos Sos { get; set; }
    }
}
