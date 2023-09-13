using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class FeedbackRating
    {
        public FeedbackRating()
        {
            RegRequestFeedbacks = new HashSet<RegRequestFeedback>();
            WorkflowFeedbacks = new HashSet<WorkflowFeedback>();
        }

        public int RatingId { get; set; }
        public string Label { get; set; }

        public virtual ICollection<RegRequestFeedback> RegRequestFeedbacks { get; set; }
        public virtual ICollection<WorkflowFeedback> WorkflowFeedbacks { get; set; }
    }
}
