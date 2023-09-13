using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Sos
    {
        public Sos()
        {
            CertificateIrudRegistrations = new HashSet<CertificateIrudRegistration>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
            Offices = new HashSet<Office>();
            OperatorIrucs = new HashSet<OperatorIruc>();
            SosCertificates = new HashSet<SosCertificate>();
        }

        public int SosId { get; set; }
        public int AgentId { get; set; }
        public string PrefixSos { get; set; }
        public string LoginSos { get; set; }
        public int CertificateId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime? OffTime { get; set; }
        public string SystemName { get; set; }
        public string OperatorName { get; set; }
        public string RecipientCode { get; set; }
        public int? ProductId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<CertificateIrudRegistration> CertificateIrudRegistrations { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<OperatorIruc> OperatorIrucs { get; set; }
        public virtual ICollection<SosCertificate> SosCertificates { get; set; }
    }
}
