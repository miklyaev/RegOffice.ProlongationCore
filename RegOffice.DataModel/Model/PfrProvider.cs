using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица провайдеров ПФР
    /// </summary>
    public partial class PfrProvider
    {
        public PfrProvider()
        {
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            Messengers = new HashSet<Messenger>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PfrProviderId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PfrProviderName { get; set; }

        /// <summary>
        /// Система
        /// </summary>
        public string PfrProviderSystem { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<Messenger> Messengers { get; set; }
    }
}
