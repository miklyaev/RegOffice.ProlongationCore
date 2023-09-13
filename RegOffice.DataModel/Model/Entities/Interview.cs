using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Interview
    {
        public Interview()
        {
            InterviewAnswers = new HashSet<InterviewAnswer>();
            InterviewSteps = new HashSet<InterviewStep>();
        }

        public int InterviewId { get; set; }
        public string Subject { get; set; }
        public DateTime CreationTime { get; set; }
        public bool MultySelect { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }

        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<InterviewAnswer> InterviewAnswers { get; set; }
        public virtual ICollection<InterviewStep> InterviewSteps { get; set; }
    }
}
