using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп прайсов
    /// </summary>
    public partial class PriceGroup
    {
        public PriceGroup()
        {
            Prices = new HashSet<Price>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PriceGroupId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PriceGroupName { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
    }
}
