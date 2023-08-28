using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обновлений объектов
    /// </summary>
    public partial class GateUpdater
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int GateUpdaterId { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Тип объекта
        /// </summary>
        public int EntityTypeId { get; set; }

        /// <summary>
        /// Гуид объекта
        /// </summary>
        public Guid EntityGuid { get; set; }

        /// <summary>
        /// Время обновления
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Время подтверждения обновления
        /// </summary>
        public DateTime? ConfirmTime { get; set; }

        public virtual EntityType EntityType { get; set; }
        public virtual Gate Gate { get; set; }
    }
}
