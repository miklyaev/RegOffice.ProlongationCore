using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица для описания доп. услуг, связанных с документооборотом
    /// </summary>
    public partial class WorkflowService
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Ссылка на документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Ссылка на состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid? GateId { get; set; }

        /// <summary>
        /// Адрес ответа
        /// </summary>
        public string CallbackAddress { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
