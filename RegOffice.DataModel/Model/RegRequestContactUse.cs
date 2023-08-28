using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Использование контактов заявления
    /// </summary>
    public partial class RegRequestContactUse
    {

        /// <summary>
        /// Контакт
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Основной
        /// </summary>
        public bool? Main { get; set; }

        public virtual RegRequestContact Contact { get; set; }
        public virtual UseType Type { get; set; }
    }
}
