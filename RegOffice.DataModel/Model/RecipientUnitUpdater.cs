using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица обновления рабочих сертификатов получателей
    /// </summary>
    public partial class RecipientUnitUpdater
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientUnitUpdaterId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientUpdaterId { get; set; }
        public int Index { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        public virtual RecipientUpdater RecipientUpdater { get; set; }
    }
}
