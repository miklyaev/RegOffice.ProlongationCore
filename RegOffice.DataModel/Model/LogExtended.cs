using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Расширенная таблица логов
    /// </summary>
    public partial class LogExtended
    {
        public LogExtended()
        {
            LogExtendedDetails = new HashSet<LogExtendedDetail>();
        }


        /// <summary>
        /// ID таблицы
        /// </summary>
        public int LogId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// ID изменяемой сущности
        /// </summary>
        public int EntityId { get; set; }

        /// <summary>
        /// Изменяемая таблица
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Тип операции
        /// </summary>
        public int LogTypeId { get; set; }

        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Логгируемая операция
        /// </summary>
        public int OperationId { get; set; }

        public virtual LogType LogType { get; set; }
        public virtual LogExtendedOperationDesc Operation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<LogExtendedDetail> LogExtendedDetails { get; set; }
    }
}
