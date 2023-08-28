using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обновления получателей
    /// </summary>
    public partial class RecipientUpdater
    {
        public RecipientUpdater()
        {
            RecipientUnitUpdaters = new HashSet<RecipientUnitUpdater>();
            Recipients = new HashSet<Recipient>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientUpdaterId { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        /// <summary>
        /// Эл. почта
        /// </summary>
        public string MailBox { get; set; }

        /// <summary>
        /// СУ
        /// </summary>
        public string VipnetNodeId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Дата подтверждения
        /// </summary>
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Дата применения
        /// </summary>
        public DateTime? ApplyDate { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Флаг отключения
        /// </summary>
        public bool TurnOff { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
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
