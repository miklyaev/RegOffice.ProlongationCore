using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица получателей
    /// </summary>
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


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid RecipientGuid { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Эл. почта
        /// </summary>
        public string MailBox { get; set; }

        /// <summary>
        /// СУ
        /// </summary>
        public string VipnetNodeId { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Именение наименования
        /// </summary>
        public bool? ChangeName { get; set; }

        /// <summary>
        /// Обновление
        /// </summary>
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
