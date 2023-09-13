using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class News
    {
        public News()
        {
            InverseParent = new HashSet<News>();
            NewsBrowsings = new HashSet<NewsBrowsing>();
            NewsFiles = new HashSet<NewsFile>();
            NewsReviews = new HashSet<NewsReviews>();
            NewsSettings = new HashSet<NewsSetting>();
            NewsTags = new HashSet<NewsTag>();
            NewsVisibilities = new HashSet<NewsVisibility>();
        }

        public int NewsId { get; set; }
        public string Topic { get; set; }
        public string Summary { get; set; }
        public DateTime CreationTime { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public int VisibilityTypeId { get; set; }
        public bool? ShowReview { get; set; }
        public int? ImageId { get; set; }
        public int? ParentId { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual News Parent { get; set; }
        public virtual User User { get; set; }
        public virtual VisibilityType VisibilityType { get; set; }
        public virtual ICollection<News> InverseParent { get; set; }
        public virtual ICollection<NewsBrowsing> NewsBrowsings { get; set; }
        public virtual ICollection<NewsFile> NewsFiles { get; set; }
        public virtual ICollection<NewsReviews> NewsReviews { get; set; }
        public virtual ICollection<NewsSetting> NewsSettings { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
    }
}
