using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SubjectType
    {
        public SubjectType()
        {
            TransactionRecipientTypes = new HashSet<Transaction>();
            TransactionSenderTypes = new HashSet<Transaction>();
        }

        public int SubjectTypeId { get; set; }
        public string SubjectTypeName { get; set; }
        public int WorkflowTypeId { get; set; }

        public virtual WorkflowType WorkflowType { get; set; }
        public virtual ICollection<Transaction> TransactionRecipientTypes { get; set; }
        public virtual ICollection<Transaction> TransactionSenderTypes { get; set; }
    }
}
