using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BlockRequisiteTask
    {
        public int BlockRequisiteTaskId { get; set; }
        public string InnListJson { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }

        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
