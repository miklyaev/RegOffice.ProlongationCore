using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица систем обновлений
    /// </summary>
    public partial class UpdateSystem
    {
        public UpdateSystem()
        {
            Gates = new HashSet<Gate>();
            ReflexTypeSystems = new HashSet<ReflexTypeSystem>();
        }


        /// <summary>
        /// ИД записи
        /// </summary>
        public int SystemId { get; set; }

        /// <summary>
        /// Название системы
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Название системы
        /// </summary>
        public string SystemDescription { get; set; }

        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<ReflexTypeSystem> ReflexTypeSystems { get; set; }
    }
}
