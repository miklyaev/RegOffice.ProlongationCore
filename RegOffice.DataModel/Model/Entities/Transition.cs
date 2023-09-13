using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Transition
    {
        public int TransitionId { get; set; }
        public int StepId { get; set; }
        public int NextStepId { get; set; }
        public int ApplicationId { get; set; }
        public int ObjectTypeId { get; set; }
        public int? ObjectId { get; set; }
        public int ConditionId { get; set; }
        public int? Priority { get; set; }

        public virtual Application Application { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Step NextStep { get; set; }
        public virtual Object Object { get; set; }
        public virtual ObjectType ObjectType { get; set; }
        public virtual Step Step { get; set; }
    }
}
