using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица классов защиты
    /// </summary>
    public partial class ProtectionClass
    {
        public ProtectionClass()
        {
            Keys = new HashSet<Key>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ProtectionClassId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ProtectionClassName { get; set; }

        /// <summary>
        /// Объектный идентификатор
        /// </summary>
        public string PolicyOid { get; set; }

        public virtual ICollection<Key> Keys { get; set; }
    }
}
