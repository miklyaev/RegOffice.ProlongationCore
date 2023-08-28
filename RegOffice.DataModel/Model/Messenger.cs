using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица курьеров
    /// </summary>
    public partial class Messenger
    {
        public Messenger()
        {
            CaMessengers = new HashSet<CaMessenger>();
            MercuryMessengerSteps = new HashSet<MercuryMessengerStep>();
            MercuryMessengers = new HashSet<MercuryMessenger>();
            MercuryRecipients = new HashSet<MercuryRecipient>();
            MessengerCertificates = new HashSet<MessengerCertificate>();
            MessengerRecipients = new HashSet<MessengerRecipient>();
            MessengerSuffixes = new HashSet<MessengerSuffix>();
            MessengerUpdaters = new HashSet<MessengerUpdater>();
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexRules = new HashSet<ReflexRule>();
            Agents = new HashSet<Agent>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string MessengerCode { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string MessengerName { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid MessengerGuid { get; set; }

        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Домен СОЭД
        /// </summary>
        public string DomainSoed { get; set; }

        /// <summary>
        /// СОС
        /// </summary>
        public int? SosId { get; set; }

        /// <summary>
        /// Входящий порт
        /// </summary>
        public int PortIn { get; set; }

        /// <summary>
        /// Исходящий порт
        /// </summary>
        public int PortOut { get; set; }

        /// <summary>
        /// СУ
        /// </summary>
        public string Suid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Регистрация в ПФР
        /// </summary>
        public bool RegPfr { get; set; }

        /// <summary>
        /// Провайдер ПФР
        /// </summary>
        public int? PfrProviderId { get; set; }

        /// <summary>
        /// Обновление
        /// </summary>
        public int? MessengerUpdaterId { get; set; }

        /// <summary>
        /// Ожидать ответ
        /// </summary>
        public bool WaitReply { get; set; }

        /// <summary>
        /// Пакет только по одному направлению
        /// </summary>
        public bool? SinglePacket { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual MessengerUpdater MessengerUpdater { get; set; }
        public virtual PfrProvider PfrProvider { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual Server Server { get; set; }
        public virtual So Sos { get; set; }
        public virtual VipnetNode Su { get; set; }
        public virtual ICollection<CaMessenger> CaMessengers { get; set; }
        public virtual ICollection<MercuryMessengerStep> MercuryMessengerSteps { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<MercuryRecipient> MercuryRecipients { get; set; }
        public virtual ICollection<MessengerCertificate> MessengerCertificates { get; set; }
        public virtual ICollection<MessengerRecipient> MessengerRecipients { get; set; }
        public virtual ICollection<MessengerSuffix> MessengerSuffixes { get; set; }
        public virtual ICollection<MessengerUpdater> MessengerUpdaters { get; set; }
        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
    }
}
