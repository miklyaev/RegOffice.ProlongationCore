using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class InterviewAnswer
    {
        public InterviewAnswer()
        {
            InterviewAgents = new HashSet<InterviewAgent>();
            InterviewUsers = new HashSet<InterviewUser>();
        }

        public int AnswerId { get; set; }
        public int InterviewId { get; set; }
        public string AnswerValue { get; set; }

        public virtual Interview Interview { get; set; }
        public virtual ICollection<InterviewAgent> InterviewAgents { get; set; }
        public virtual ICollection<InterviewUser> InterviewUsers { get; set; }
    }
}
