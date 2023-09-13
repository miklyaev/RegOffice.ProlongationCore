using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Workflow
    {
        public Workflow()
        {
            Keys = new HashSet<Key>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegCertRequests = new HashSet<RegCertRequest>();
            Transactions = new HashSet<Transaction>();
            WorkflowFeedbacks = new HashSet<WorkflowFeedback>();
            WorkflowServiceSteps = new HashSet<WorkflowServiceStep>();
            WorkflowServices = new HashSet<WorkflowService>();
        }

        public int WorkflowId { get; set; }
        public int WorkflowTypeId { get; set; }
        public Guid WorkflowGuid { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public string CallbackAddress { get; set; }

        public virtual WorkflowType WorkflowType { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual RejectedRegRequest RejectedRegRequest { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<WorkflowFeedback> WorkflowFeedbacks { get; set; }
        public virtual ICollection<WorkflowServiceStep> WorkflowServiceSteps { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
