using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица зон обслуживания точек
    /// </summary>
    public partial class PointZone
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointZoneId { get; set; }

        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        public virtual Point Point { get; set; }
        public virtual Region Region { get; set; }
    }
}
