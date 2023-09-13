using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Recipient
    {
        public Recipient()
        {
            MercuryRecipientSteps = new HashSet<MercuryRecipientStep>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MercuryRoutes = new HashSet<MercuryRoute>();
            MessengerRecipients = new HashSet<MessengerRecipient>();
            RecipientCertificates = new HashSet<RecipientCertificate>();
            RecipientDuplicates = new HashSet<RecipientDuplicate>();
            RecipientUnits = new HashSet<RecipientUnit>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
        }

        public int RecipientId { get; set; }
        public string RecipientCode { get; set; }
        public string RecipientName { get; set; }
        public Guid RecipientGuid { get; set; }
        public int RegionId { get; set; }
        public int ProtocolId { get; set; }
        public int? CertificateId { get; set; }
        public string MailBox { get; set; }
        public string VipnetNodeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? OffTime { get; set; }
        public bool? ChangeName { get; set; }
        public int? RecipientUpdaterId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual RecipientUpdater RecipientUpdater { get; set; }
        public virtual Region Region { get; set; }
        public virtual VipnetNode VipnetNode { get; set; }
        public virtual ICollection<MercuryRecipientStep> MercuryRecipientSteps { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MercuryRoute> MercuryRoutes { get; set; }
        public virtual ICollection<MessengerRecipient> MessengerRecipients { get; set; }
        public virtual ICollection<RecipientCertificate> RecipientCertificates { get; set; }
        public virtual ICollection<RecipientDuplicate> RecipientDuplicates { get; set; }
        public virtual ICollection<RecipientUnit> RecipientUnits { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
    }
}
