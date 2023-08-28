using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица возможных оценок при обратной связи
    /// </summary>
    public partial class FeedbackRating
    {
        public FeedbackRating()
        {
            RegRequestFeedbacks = new HashSet<RegRequestFeedback>();
            WorkflowFeedbacks = new HashSet<WorkflowFeedback>();
        }


        /// <summary>
        /// Оценка
        /// </summary>
        public int RatingId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Label { get; set; }

        public virtual ICollection<RegRequestFeedback> RegRequestFeedbacks { get; set; }
        public virtual ICollection<WorkflowFeedback> WorkflowFeedbacks { get; set; }
    }
}
