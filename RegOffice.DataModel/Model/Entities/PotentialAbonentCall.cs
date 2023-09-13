using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentCall
    {
        public int CallId { get; set; }
        public int PotentialAbonentId { get; set; }
        public int StepId { get; set; }
        public DateTime CallTime { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }
        public DateTime? PlannedCallTime { get; set; }
        public int? StepReasonId { get; set; }

        public virtual PotentialAbonentCallState Step { get; set; }
        public virtual PotentialAbonentRejectionReason StepReason { get; set; }
        public virtual User User { get; set; }
    }
}
