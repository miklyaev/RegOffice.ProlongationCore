using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний центров регистрации
    /// </summary>
    public partial class RaStep
    {

        /// <summary>
        /// Центр регистрации
        /// </summary>
        public int RaId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Ra Ra { get; set; }
        public virtual Step Step { get; set; }
    }
}
