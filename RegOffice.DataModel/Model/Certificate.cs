using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов
    /// </summary>
    public partial class Certificate
    {
        public Certificate()
        {
            InverseTrustCertificate = new HashSet<Certificate>();
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
            Sos = new HashSet<So>();
            SosCertificates = new HashSet<SosCertificate>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Общее имя
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Отпечаток
        /// </summary>
        public string ThumbPrint { get; set; }

        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string SubjectKeyId { get; set; }

        /// <summary>
        /// Идентификатор ключа издателя
        /// </summary>
        public string AuthorityKeyId { get; set; }

        /// <summary>
        /// Общее имя издателя
        /// </summary>
        public string IssuerCommonName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int CertificateTypeId { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid CertificateGuid { get; set; }

        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateTime InitialTime { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Корневой
        /// </summary>
        public int? TrustCertificateId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Печатная форма расписки
        /// </summary>
        public int? ReceiptId { get; set; }

        public virtual CertificateType CertificateType { get; set; }
        public virtual File Receipt { get; set; }
        public virtual Step Step { get; set; }
        public virtual Certificate TrustCertificate { get; set; }
        public virtual Ca Ca { get; set; }
        public virtual CertificateRevocation CertificateRevocation { get; set; }
        public virtual RegCertRequest RegCertRequest { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Certificate> InverseTrustCertificate { get; set; }
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
        public virtual ICollection<So> Sos { get; set; }
        public virtual ICollection<SosCertificate> SosCertificates { get; set; }
    }
}
