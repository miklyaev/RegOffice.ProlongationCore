using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица отражений для продукта
    /// </summary>
    public partial class ReflexProduct
    {

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// База
        /// </summary>
        public int ReflexId { get; set; }

        /// <summary>
        /// Тип базы
        /// </summary>
        public int ReflexTypeId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
    }
}
