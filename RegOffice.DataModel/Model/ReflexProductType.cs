using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица отражений для типа продукта
    /// </summary>
    public partial class ReflexProductType
    {

        /// <summary>
        /// Отражение
        /// </summary>
        public int ReflexId { get; set; }

        /// <summary>
        /// Тип отражения
        /// </summary>
        public int ReflexTypeId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
    }
}
