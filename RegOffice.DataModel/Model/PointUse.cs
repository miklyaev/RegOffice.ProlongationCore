using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Применение точек
    /// </summary>
    public partial class PointUse
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointUseId { get; set; }

        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }

        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }

        public virtual Point Point { get; set; }
        public virtual PointUseType Type { get; set; }
    }
}
