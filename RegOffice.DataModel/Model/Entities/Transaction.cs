using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int WorkflowId { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTime ReceiveTime { get; set; }
        public DateTime? FormationTime { get; set; }
        public int SenderTypeId { get; set; }
        public string SenderName { get; set; }
        public int RecipientTypeId { get; set; }
        public string RecipientName { get; set; }
        public int? PacketId { get; set; }
        public string FormatVersion { get; set; }

        public virtual SubjectType RecipientType { get; set; }
        public virtual SubjectType SenderType { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
