using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица уполномоченных представителей
    /// </summary>
    public partial class ProxyAgent
    {
        public ProxyAgent()
        {
            Products = new HashSet<Product>();
            RegRequests = new HashSet<RegRequest>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProxyAgentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ProxyAgentName { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Office Office { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
