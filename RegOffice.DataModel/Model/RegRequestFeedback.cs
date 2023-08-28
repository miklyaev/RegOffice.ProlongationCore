using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обратной связи по заявлениям
    /// </summary>
    public partial class RegRequestFeedback
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FeedbackId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int? RatingId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual FeedbackRating Rating { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
