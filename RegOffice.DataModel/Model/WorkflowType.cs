using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов документооборота
    /// </summary>
    public partial class WorkflowType
    {
        public WorkflowType()
        {
            PotentialAbonentWorkflows = new HashSet<PotentialAbonentWorkflow>();
            SubjectTypes = new HashSet<SubjectType>();
            TransactionTypes = new HashSet<TransactionType>();
            WorkflowDocTypes = new HashSet<WorkflowDocType>();
            Workflows = new HashSet<Workflow>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int WorkflowTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string WorkflowTypeName { get; set; }

        public virtual ICollection<PotentialAbonentWorkflow> PotentialAbonentWorkflows { get; set; }
        public virtual ICollection<SubjectType> SubjectTypes { get; set; }
        public virtual ICollection<TransactionType> TransactionTypes { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
