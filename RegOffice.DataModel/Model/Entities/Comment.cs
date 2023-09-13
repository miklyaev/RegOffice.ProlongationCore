using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Comment
    {
        public Comment()
        {
            OfdDiscounts = new HashSet<OfdDiscount>();
            OfdPins = new HashSet<OfdPin>();
        }

        public int CommentId { get; set; }
        public string CommentText { get; set; }

        public virtual ICollection<OfdDiscount> OfdDiscounts { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
