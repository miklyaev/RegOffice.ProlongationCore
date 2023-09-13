using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Server
    {
        public Server()
        {
            Ips = new HashSet<Ip>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
        }

        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public int AgentId { get; set; }
        public string DomainIn { get; set; }
        public string DomainOut { get; set; }
        public bool PublicServer { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<Ip> Ips { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
