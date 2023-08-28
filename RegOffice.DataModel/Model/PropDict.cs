using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица со словарем реквизитов
    /// </summary>
    public partial class PropDict
    {

        /// <summary>
        /// Тип
        /// </summary>
        public int PropTypeId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string PropValue { get; set; }

        public virtual PropType PropType { get; set; }
    }
}
