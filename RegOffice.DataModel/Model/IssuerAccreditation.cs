using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица аккредитаций издателей
    /// </summary>
    public partial class IssuerAccreditation
    {

        /// <summary>
        /// Идентификатор аккредитации
        /// </summary>
        public int IssuerAccreditationId { get; set; }

        /// <summary>
        /// Издатель
        /// </summary>
        public int IssuerId { get; set; }

        /// <summary>
        /// Дата получения аккредитации
        /// </summary>
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Дата отзыва аккредитации
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        public virtual Issuer Issuer { get; set; }
    }
}
