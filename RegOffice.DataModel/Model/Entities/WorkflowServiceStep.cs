using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class WorkflowServiceStep
    {
        public int WorkflowId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }

        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
