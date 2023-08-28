using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица видов объектов для обновления
    /// </summary>
    public partial class EntityType
    {
        public EntityType()
        {
            GateUpdaters = new HashSet<GateUpdater>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int EntityTypeId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<GateUpdater> GateUpdaters { get; set; }
    }
}
