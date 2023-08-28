using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdDiscount
    {
        public OfdDiscount()
        {
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Ид.
        /// </summary>
        public int OfdDiscountId { get; set; }

        /// <summary>
        /// Ид. скидки
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Лимит использования
        /// </summary>
        public int? UseLimit { get; set; }

        /// <summary>
        /// Ид. коментария
        /// </summary>
        public int? CommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
