using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            NewsTags = new HashSet<NewsTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public int? TagGroupId { get; set; }

        public virtual TagGroup TagGroup { get; set; }
        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}
