using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Certificate
    {
        public Certificate()
        {
            AstralWorkflowClients = new HashSet<AstralWorkflowClient>();
            CaCertificates = new HashSet<CaCertificate>();
            CertificateIrudRegistrations = new HashSet<CertificateIrudRegistration>();
            CertificateRequests = new HashSet<CertificateRequest>();
            CertificateRevokeRequests = new HashSet<CertificateRevokeRequest>();
            CertificateServices = new HashSet<CertificateService>();
            CertificateSteps = new HashSet<CertificateStep>();
            CertificateTariffs = new HashSet<CertificateTariff>();
            Dsses = new HashSet<Dss>();
            Gates = new HashSet<Gate>();
            InverseTrustCertificate = new HashSet<Certificate>();
            Keys = new HashSet<Key>();
            MessengerCertificates = new HashSet<MessengerCertificate>();
            Messengers = new HashSet<Messenger>();
            OfficeCertificates = new HashSet<OfficeCertificate>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            PfrProviders = new HashSet<PfrProvider>();
            RecipientCertificates = new HashSet<RecipientCertificate>();
            RecipientUnits = new HashSet<RecipientUnit>();
            Recipients = new HashSet<Recipient>();
            RegCertRequests = new HashSet<RegCertRequest>();
            Sos = new HashSet<Sos>();
            SosCertificates = new HashSet<SosCertificate>();
        }

        public int CertificateId { get; set; }
        public string CommonName { get; set; }
        public string ThumbPrint { get; set; }
        public string SubjectKeyId { get; set; }
        public string AuthorityKeyId { get; set; }
        public string IssuerCommonName { get; set; }
        public int CertificateTypeId { get; set; }
        public Guid CertificateGuid { get; set; }
        public DateTime InitialTime { get; set; }
        public DateTime EndTime { get; set; }
        public string SerialNumber { get; set; }
        public int? TrustCertificateId { get; set; }
        public int StepId { get; set; }
        public int? CertId { get; set; }
        public string Message { get; set; }
        public int? ReceiptId { get; set; }

        public virtual CertificateType CertificateType { get; set; }
        public virtual File Receipt { get; set; }
        public virtual Step Step { get; set; }
        public virtual Certificate TrustCertificate { get; set; }
        public virtual Ca Ca { get; set; }
        public virtual CertificateRevocation CertificateRevocation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AstralWorkflowClient> AstralWorkflowClients { get; set; }
        public virtual ICollection<CaCertificate> CaCertificates { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrations { get; set; }
        public virtual ICollection<CertificateRequest> CertificateRequests { get; set; }
        public virtual ICollection<CertificateRevokeRequest> CertificateRevokeRequests { get; set; }
        public virtual ICollection<CertificateService> CertificateServices { get; set; }
        public virtual ICollection<CertificateStep> CertificateSteps { get; set; }
        public virtual ICollection<CertificateTariff> CertificateTariffs { get; set; }
        public virtual ICollection<Dss> Dsses { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<Certificate> InverseTrustCertificate { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<MessengerCertificate> MessengerCertificates { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<OfficeCertificate> OfficeCertificates { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<PfrProvider> PfrProviders { get; set; }
        public virtual ICollection<RecipientCertificate> RecipientCertificates { get; set; }
        public virtual ICollection<RecipientUnit> RecipientUnits { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<Sos> Sos { get; set; }
        public virtual ICollection<SosCertificate> SosCertificates { get; set; }
    }
}
