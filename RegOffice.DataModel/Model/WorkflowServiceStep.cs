using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний услуг, связанных с документооборотом
    /// </summary>
    public partial class WorkflowServiceStep
    {

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
