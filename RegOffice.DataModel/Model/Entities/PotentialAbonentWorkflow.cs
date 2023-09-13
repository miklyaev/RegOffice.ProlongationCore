using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentWorkflow
    {
        public Guid WorkflowGuid { get; set; }
        public int PotentialAbonentId { get; set; }
        public int WorkflowTypeId { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public int? RegBankRequestId { get; set; }
        public string Message { get; set; }

        public virtual RegBankRequest RegBankRequest { get; set; }
        public virtual WorkflowType WorkflowType { get; set; }
    }
}
