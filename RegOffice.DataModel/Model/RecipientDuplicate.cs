using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица дублированных получателей
    /// </summary>
    public partial class RecipientDuplicate
    {

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid DuplicateGuid { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int? Index { get; set; }

        public virtual Recipient Recipient { get; set; }
    }
}
