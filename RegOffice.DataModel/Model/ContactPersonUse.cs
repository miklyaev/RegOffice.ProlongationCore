using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Использование контактов сотрудников
    /// </summary>
    public partial class ContactPersonUse
    {

        /// <summary>
        /// Контакт сотрудника
        /// </summary>
        public int ContactPersonId { get; set; }

        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Основной
        /// </summary>
        public bool? Main { get; set; }

        public virtual ContactPerson ContactPerson { get; set; }
        public virtual UseType Type { get; set; }
    }
}
