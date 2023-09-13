using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class WorkflowFeedback
    {
        public int FeedbackId { get; set; }
        public int WorkflowId { get; set; }
        public int? RatingId { get; set; }
        public string Message { get; set; }

        public virtual FeedbackRating Rating { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
