using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документооборотов для потенциальных клиентов
    /// </summary>
    public partial class PotentialAbonentWorkflow
    {

        /// <summary>
        /// GUID документооборота
        /// </summary>
        public Guid WorkflowGuid { get; set; }

        /// <summary>
        /// Потенциальный абонент
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartedTime { get; set; }

        /// <summary>
        /// Дата завершения
        /// </summary>
        public DateTime? CompletedTime { get; set; }

        /// <summary>
        /// Заявление на БГ
        /// </summary>
        public int? RegBankRequestId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual RegBankRequest RegBankRequest { get; set; }
        public virtual WorkflowType WorkflowType { get; set; }
    }
}
