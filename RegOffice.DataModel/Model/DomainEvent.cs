using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица доменных событий
    /// </summary>
    public partial class DomainEvent
    {

        /// <summary>
        /// Идентификатор события
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Тип события
        /// </summary>
        public Guid EventType { get; set; }

        /// <summary>
        /// Тело события
        /// </summary>
        public string EventBody { get; set; }

        /// <summary>
        /// Событие отправлено в шину
        /// </summary>
        public bool IsPublished { get; set; }
    }
}
