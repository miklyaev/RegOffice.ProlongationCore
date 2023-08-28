using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обратной связи по документооборотам
    /// </summary>
    public partial class WorkflowFeedback
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FeedbackId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int? RatingId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual FeedbackRating Rating { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
