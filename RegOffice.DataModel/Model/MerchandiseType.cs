using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class MerchandiseType
    {
        public MerchandiseType()
        {
            Merchandises = new HashSet<Merchandise>();
        }


        /// <summary>
        /// Ид
        /// </summary>
        public int MerchandiseTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string MerchandiseTypeName { get; set; }

        public virtual ICollection<Merchandise> Merchandises { get; set; }
    }
}
