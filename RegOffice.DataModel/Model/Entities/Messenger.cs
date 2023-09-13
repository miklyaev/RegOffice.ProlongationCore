using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Messenger
    {
        public Messenger()
        {
            CaMessengers = new HashSet<CaMessenger>();
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengers = new HashSet<MercuryMessenger>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MessengerAgents = new HashSet<MessengerAgent>();
            MessengerCertificates = new HashSet<MessengerCertificate>();
            MessengerRecipients = new HashSet<MessengerRecipient>();
            MessengerSuffixes = new HashSet<MessengerSuffix>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexRules = new HashSet<ReflexRule>();
        }

        public int MessengerId { get; set; }
        public string MessengerCode { get; set; }
        public string MessengerName { get; set; }
        public Guid MessengerGuid { get; set; }
        public int ServerId { get; set; }
        public int ProtocolId { get; set; }
        public int? CertificateId { get; set; }
        public string DomainSoed { get; set; }
        public int? SosId { get; set; }
        public int PortIn { get; set; }
        public int PortOut { get; set; }
        public string Suid { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? OffTime { get; set; }
        public bool RegPfr { get; set; }
        public int? PfrProviderId { get; set; }
        public int? MessengerUpdaterId { get; set; }
        public bool WaitReply { get; set; }
        public bool? SinglePacket { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual MessengerUpdater MessengerUpdater { get; set; }
        public virtual PfrProvider PfrProvider { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual Server Server { get; set; }
        public virtual Sos Sos { get; set; }
        public virtual VipnetNode Su { get; set; }
        public virtual ICollection<CaMessenger> CaMessengers { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MessengerAgent> MessengerAgents { get; set; }
        public virtual ICollection<MessengerCertificate> MessengerCertificates { get; set; }
        public virtual ICollection<MessengerRecipient> MessengerRecipients { get; set; }
        public virtual ICollection<MessengerSuffix> MessengerSuffixes { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
    }
}
