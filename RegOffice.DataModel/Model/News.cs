using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица новостей
    /// </summary>
    public partial class News
    {
        public News()
        {
            InverseParent = new HashSet<News>();
            NewsBrowsings = new HashSet<NewsBrowsing>();
            NewsFiles = new HashSet<NewsFile>();
            NewsReviews = new HashSet<NewsReview>();
            NewsSettings = new HashSet<NewsSetting>();
            NewsVisibilities = new HashSet<NewsVisibility>();
            Tags = new HashSet<Tag>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Тип видимости
        /// </summary>
        public int VisibilityTypeId { get; set; }

        /// <summary>
        /// Отображать поле ввода отзыва
        /// </summary>
        public bool? ShowReview { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        public int? ImageId { get; set; }

        /// <summary>
        /// Узел родитель
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual News Parent { get; set; }
        public virtual User User { get; set; }
        public virtual VisibilityType VisibilityType { get; set; }
        public virtual ICollection<News> InverseParent { get; set; }
        public virtual ICollection<NewsBrowsing> NewsBrowsings { get; set; }
        public virtual ICollection<NewsFile> NewsFiles { get; set; }
        public virtual ICollection<NewsReview> NewsReviews { get; set; }
        public virtual ICollection<NewsSetting> NewsSettings { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
