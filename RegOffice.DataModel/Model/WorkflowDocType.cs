using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица приложений документооборота
    /// </summary>
    public partial class WorkflowDocType
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int WorkflowDocTypeId { get; set; }

        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        /// <summary>
        /// Тип абонента
        /// </summary>
        public int AbonentTypeId { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public int DocTypeId { get; set; }

        /// <summary>
        /// Обязательный
        /// </summary>
        public bool Required { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual WorkflowType WorkflowType { get; set; }
    }
}
