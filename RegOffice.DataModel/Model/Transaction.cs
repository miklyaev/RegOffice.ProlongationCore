using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица транзакций документооборотов
    /// </summary>
    public partial class Transaction
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransactionId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TransactionTypeId { get; set; }

        /// <summary>
        /// Дата получения
        /// </summary>
        public DateTime ReceiveTime { get; set; }

        /// <summary>
        /// Дата формирования
        /// </summary>
        public DateTime? FormationTime { get; set; }

        /// <summary>
        /// Тип отправителя
        /// </summary>
        public int SenderTypeId { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Тип получателя
        /// </summary>
        public int RecipientTypeId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Пакет
        /// </summary>
        public int? PacketId { get; set; }

        /// <summary>
        /// Версия формата
        /// </summary>
        public string FormatVersion { get; set; }

        public virtual SubjectType RecipientType { get; set; }
        public virtual SubjectType SenderType { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
