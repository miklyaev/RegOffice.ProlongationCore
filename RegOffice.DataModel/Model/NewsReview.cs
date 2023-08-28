using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица с отзывами к новостям
    /// </summary>
    public partial class NewsReview
    {

        /// <summary>
        /// идентификатор отзыва новости
        /// </summary>
        public int NewsReviewId { get; set; }

        /// <summary>
        /// новость
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// текст отзыва
        /// </summary>
        public string ReviewText { get; set; }

        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
