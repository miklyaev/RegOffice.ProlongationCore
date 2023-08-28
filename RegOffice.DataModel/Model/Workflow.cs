using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица документооборотов
    /// </summary>
    public partial class Workflow
    {
        public Workflow()
        {
            Keys = new HashSet<Key>();
            Transactions = new HashSet<Transaction>();
            WorkflowFeedbacks = new HashSet<WorkflowFeedback>();
            WorkflowServiceSteps = new HashSet<WorkflowServiceStep>();
            WorkflowServices = new HashSet<WorkflowService>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int WorkflowTypeId { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid WorkflowGuid { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartedTime { get; set; }

        /// <summary>
        /// Дата завершения
        /// </summary>
        public DateTime? CompletedTime { get; set; }

        /// <summary>
        /// Адрес ответа
        /// </summary>
        public string CallbackAddress { get; set; }

        public virtual WorkflowType WorkflowType { get; set; }
        public virtual RegBankRequest RegBankRequest { get; set; }
        public virtual RegCertRequest RegCertRequest { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual RejectedRegRequest RejectedRegRequest { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<WorkflowFeedback> WorkflowFeedbacks { get; set; }
        public virtual ICollection<WorkflowServiceStep> WorkflowServiceSteps { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
