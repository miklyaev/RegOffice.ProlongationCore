using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица версий БД
    /// </summary>
    public partial class Version
    {

        /// <summary>
        /// Номер
        /// </summary>
        public string VersionNumber { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
