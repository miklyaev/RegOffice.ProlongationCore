using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RecipientUpdater
    {
        public RecipientUpdater()
        {
            RecipientUnitUpdaters = new HashSet<RecipientUnitUpdater>();
            Recipients = new HashSet<Recipient>();
        }

        public int RecipientUpdaterId { get; set; }
        public string RecipientCode { get; set; }
        public string RecipientName { get; set; }
        public int RegionId { get; set; }
        public int ProtocolId { get; set; }
        public string MailBox { get; set; }
        public string VipnetNodeId { get; set; }
        public int RecipientId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int OfficeId { get; set; }
        public int? UserId { get; set; }
        public bool TurnOff { get; set; }
        public int? CertId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual Region Region { get; set; }
        public virtual User User { get; set; }
        public virtual VipnetNode VipnetNode { get; set; }
        public virtual ICollection<RecipientUnitUpdater> RecipientUnitUpdaters { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
    }
}
