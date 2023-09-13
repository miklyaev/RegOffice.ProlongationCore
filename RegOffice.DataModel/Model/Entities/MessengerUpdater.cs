using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MessengerUpdater
    {
        public MessengerUpdater()
        {
            Messengers = new HashSet<Messenger>();
        }

        public int MessengerUpdaterId { get; set; }
        public string MessengerCode { get; set; }
        public string MessengerName { get; set; }
        public int ServerId { get; set; }
        public int ProtocolId { get; set; }
        public string DomainSoed { get; set; }
        public int? SosId { get; set; }
        public int PortIn { get; set; }
        public int PortOut { get; set; }
        public string Suid { get; set; }
        public bool RegPfr { get; set; }
        public int? PfrProviderId { get; set; }
        public int MessengerId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int OfficeId { get; set; }
        public int? UserId { get; set; }
        public bool WaitReply { get; set; }
        public int? CertId { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Office Office { get; set; }
        public virtual PfrProvider PfrProvider { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual Server Server { get; set; }
        public virtual Sos Sos { get; set; }
        public virtual VipnetNode Su { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
