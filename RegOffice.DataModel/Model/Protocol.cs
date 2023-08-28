using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица протоколов
    /// </summary>
    public partial class Protocol
    {
        public Protocol()
        {
            GateProtocols = new HashSet<GateProtocol>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
            PluginTariffs = new HashSet<PluginTariff>();
            Plugins = new HashSet<Plugin>();
            ProductPersonAvailableProtocols = new HashSet<ProductPersonAvailableProtocol>();
            ProductPotentialMemberProtocols = new HashSet<ProductPotentialMemberProtocol>();
            RecipientUpdaters = new HashSet<RecipientUpdater>();
            Recipients = new HashSet<Recipient>();
            RegRequestMemberAvailableProtocols = new HashSet<RegRequestMemberAvailableProtocol>();
            RegRequestPotentialMemberProtocols = new HashSet<RegRequestPotentialMemberProtocol>();
            RegRequestRecipients = new HashSet<RegRequestRecipient>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ProtocolName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Псевдоним
        /// </summary>
        public string ProtocolAlias { get; set; }

        public virtual ICollection<GateProtocol> GateProtocols { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
        public virtual ICollection<PluginTariff> PluginTariffs { get; set; }
        public virtual ICollection<Plugin> Plugins { get; set; }
        public virtual ICollection<ProductPersonAvailableProtocol> ProductPersonAvailableProtocols { get; set; }
        public virtual ICollection<ProductPotentialMemberProtocol> ProductPotentialMemberProtocols { get; set; }
        public virtual ICollection<RecipientUpdater> RecipientUpdaters { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
        public virtual ICollection<RegRequestMemberAvailableProtocol> RegRequestMemberAvailableProtocols { get; set; }
        public virtual ICollection<RegRequestPotentialMemberProtocol> RegRequestPotentialMemberProtocols { get; set; }
        public virtual ICollection<RegRequestRecipient> RegRequestRecipients { get; set; }
    }
}
