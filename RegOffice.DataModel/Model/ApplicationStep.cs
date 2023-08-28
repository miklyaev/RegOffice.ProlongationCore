using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний приложений
    /// </summary>
    public partial class ApplicationStep
    {

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Application Application { get; set; }
        public virtual Step Step { get; set; }
    }
}
