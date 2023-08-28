using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи курьеров с получателями
    /// </summary>
    public partial class MessengerRecipient
    {

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Курьер по умолчанию
        /// </summary>
        public bool Default { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
