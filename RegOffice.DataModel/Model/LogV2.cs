using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица лога
    /// </summary>
    public partial class LogV2
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid LogId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int LogTypeId { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string LogMessage { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public int? LogCode { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Имя хоста
        /// </summary>
        public string AppInstance { get; set; }

        public virtual Application Application { get; set; }
        public virtual LogType LogType { get; set; }
    }
}
