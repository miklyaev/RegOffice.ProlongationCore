using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица отражений для типа применения
    /// </summary>
    public partial class ReflexUseType
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
        /// Тип применения
        /// </summary>
        public int UseTypeId { get; set; }

        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
        public virtual UseType UseType { get; set; }
    }
}
