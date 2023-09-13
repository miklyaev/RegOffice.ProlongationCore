using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TagGroup
    {
        public TagGroup()
        {
            Tags = new HashSet<Tag>();
        }

        public int TagGroupId { get; set; }
        public string TagGroupName { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
