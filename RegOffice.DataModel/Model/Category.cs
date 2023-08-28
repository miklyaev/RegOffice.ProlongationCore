using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица категорий абонентов
    /// </summary>
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            RegRequests = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
