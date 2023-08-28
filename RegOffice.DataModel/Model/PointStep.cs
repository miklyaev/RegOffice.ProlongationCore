using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний точек
    /// </summary>
    public partial class PointStep
    {

        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Point Point { get; set; }
        public virtual Step Step { get; set; }
    }
}
