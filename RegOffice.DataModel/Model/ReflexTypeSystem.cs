using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи типов БД рефлекса с системами
    /// </summary>
    public partial class ReflexTypeSystem
    {

        /// <summary>
        /// ИД записи
        /// </summary>
        public int ReflexTypeSystemId { get; set; }

        /// <summary>
        /// Тип БД рефлекс
        /// </summary>
        public int ReflexTypeId { get; set; }

        /// <summary>
        /// Система
        /// </summary>
        public int SystemId { get; set; }

        public virtual ReflexType ReflexType { get; set; }
        public virtual UpdateSystem System { get; set; }
    }
}
