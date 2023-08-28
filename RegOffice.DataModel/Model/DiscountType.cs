using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов скидок
    /// </summary>
    public partial class DiscountType
    {
        public DiscountType()
        {
            Discounts = new HashSet<Discount>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int DiscountTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string DiscountTypeName { get; set; }

        public virtual ICollection<Discount> Discounts { get; set; }
    }
}
