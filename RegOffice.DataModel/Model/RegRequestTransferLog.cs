using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица логирования переноса заявлений
    /// </summary>
    public partial class RegRequestTransferLog
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestTransferId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Предыдущий офис
        /// </summary>
        public int PreviousOfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Office PreviousOffice { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual User User { get; set; }
    }
}
