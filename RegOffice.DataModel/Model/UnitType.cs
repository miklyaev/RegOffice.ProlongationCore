using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов ед. измерений
    /// </summary>
    public partial class UnitType
    {
        public UnitType()
        {
            Units = new HashSet<Unit>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int UnitTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string UnitTypeName { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}
