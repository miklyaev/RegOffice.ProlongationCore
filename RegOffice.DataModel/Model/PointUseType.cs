using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Тип применения точки
    /// </summary>
    public partial class PointUseType
    {
        public PointUseType()
        {
            PointUses = new HashSet<PointUse>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int UseTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string UseTypeName { get; set; }

        public virtual ICollection<PointUse> PointUses { get; set; }
    }
}
