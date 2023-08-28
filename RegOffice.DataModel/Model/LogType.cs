using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов лога
    /// </summary>
    public partial class LogType
    {
        public LogType()
        {
            LogExtendeds = new HashSet<LogExtended>();
            LogV222s = new HashSet<LogV222>();
            LogV2s = new HashSet<LogV2>();
            Logs = new HashSet<Log>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int LogTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string LogTypeName { get; set; }

        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
        public virtual ICollection<LogV222> LogV222s { get; set; }
        public virtual ICollection<LogV2> LogV2s { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
