using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class Comment
    {
        public Comment()
        {
            OfdDiscounts = new HashSet<OfdDiscount>();
            OfdPins = new HashSet<OfdPin>();
        }


        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string CommentText { get; set; }

        public virtual ICollection<OfdDiscount> OfdDiscounts { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
