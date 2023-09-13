using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class WorkflowService
    {
        public int ServiceId { get; set; }
        public int WorkflowId { get; set; }
        public int ServiceTypeId { get; set; }
        public int StepId { get; set; }
        public string Message { get; set; }
        public Guid? GateId { get; set; }
        public string CallbackAddress { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
