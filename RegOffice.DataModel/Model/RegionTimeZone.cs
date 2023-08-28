using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица временных зон регионов
    /// </summary>
    public partial class RegionTimeZone
    {

        /// <summary>
        /// Идентификатор региона
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Смещение времени
        /// </summary>
        public TimeSpan TimeOffset { get; set; }

        public virtual Region Region { get; set; }
    }
}
