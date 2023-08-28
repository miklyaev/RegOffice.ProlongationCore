using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица лога операций
    /// </summary>
    public partial class OperationLog
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OperationLogId { get; set; }

        /// <summary>
        /// Операция
        /// </summary>
        public int OperationId { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Время выполнения
        /// </summary>
        public DateTime RunTime { get; set; }

        /// <summary>
        /// ГУИД продукта
        /// </summary>
        public Guid? ProductGuid { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        public virtual Application Application { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual User User { get; set; }
    }
}
