using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица запросов для отчетов
    /// </summary>
    public partial class ReportQuery
    {

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int ReportQueryId { get; set; }

        /// <summary>
        /// SQL-запрос
        /// </summary>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }
    }
}
