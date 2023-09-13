using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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

        public int WorkflowTypeId { get; set; }
        public string WorkflowTypeName { get; set; }

        public virtual ICollection<PotentialAbonentWorkflow> PotentialAbonentWorkflows { get; set; }
        public virtual ICollection<SubjectType> SubjectTypes { get; set; }
        public virtual ICollection<TransactionType> TransactionTypes { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
