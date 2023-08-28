using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов значений
    /// </summary>
    public partial class ValueType
    {
        public ValueType()
        {
            Objects = new HashSet<Object>();
            Settings = new HashSet<Setting>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ValueTypeId { get; set; }

        /// <summary>
        /// Кодовое имя
        /// </summary>
        public string CodeName { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ValueTypeName { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
    }
}
