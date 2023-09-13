using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdDiscount
    {
        public OfdDiscount()
        {
            OfdPins = new HashSet<OfdPin>();
        }

        public int OfdDiscountId { get; set; }
        public int DiscountId { get; set; }
        public int? UseLimit { get; set; }
        public int? CommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
