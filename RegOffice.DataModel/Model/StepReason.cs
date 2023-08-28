using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Причины статусов
    /// </summary>
    public partial class StepReason
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int StepReasonId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string StepReasonName { get; set; }
    }
}
