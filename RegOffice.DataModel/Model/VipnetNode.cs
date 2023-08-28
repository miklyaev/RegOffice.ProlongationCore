using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сетевых узлов ViPNet
    /// </summary>
    public partial class VipnetNode
    {
        public VipnetNode()
        {
            Agents = new HashSet<Agent>();
            Cas = new HashSet<Ca>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
            Offices = new HashSet<Office>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            Recipients = new HashSet<Recipient>();
            VipnetUsers = new HashSet<VipnetUser>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public string VipnetNodeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string VipnetNodeName { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Ca> Cas { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
        public virtual ICollection<VipnetUser> VipnetUsers { get; set; }
    }
}
