using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов реквизитов
    /// </summary>
    public partial class PropType
    {
        public PropType()
        {
            PropDicts = new HashSet<PropDict>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int PropTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PropTypeName { get; set; }

        public virtual ICollection<PropDict> PropDicts { get; set; }
    }
}
