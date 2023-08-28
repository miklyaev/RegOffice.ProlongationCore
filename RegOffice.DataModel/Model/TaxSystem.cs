using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица систем налогообложения
    /// </summary>
    public partial class TaxSystem
    {
        public TaxSystem()
        {
            Products = new HashSet<Product>();
        }


        /// <summary>
        /// Идентификатор системы налогообложения
        /// </summary>
        public int TaxSystemId { get; set; }

        /// <summary>
        /// Название системы налогообложения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Обозначение системы налогообложения
        /// </summary>
        public string Alias { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
