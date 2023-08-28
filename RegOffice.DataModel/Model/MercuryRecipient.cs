using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица получателей АстралОтчет
    /// </summary>
    public partial class MercuryRecipient
    {
        public MercuryRecipient()
        {
            MercuryRoutes = new HashSet<MercuryRoute>();
        }


        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Номер участка
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? StepId { get; set; }
        public int? UserId { get; set; }

        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string PackId { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual MercuryMessenger Me { get; set; }
        public virtual Product Mercury { get; set; }
        public virtual Messenger Messenger { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<MercuryRoute> MercuryRoutes { get; set; }
    }
}
