using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний получателей продуктов
    /// </summary>
    public partial class MercuryRecipientStep
    {

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
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

        public virtual Product Mercury { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
