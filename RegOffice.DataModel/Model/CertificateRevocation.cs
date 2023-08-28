using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Автоматический отзыв сертификата
    /// </summary>
    public partial class CertificateRevocation
    {

        /// <summary>
        /// Отзываемый сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Действие
        /// </summary>
        public int ActionId { get; set; }

        /// <summary>
        /// Причина отзыва
        /// </summary>
        public int? ReasonId { get; set; }

        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        public virtual CaAction Action { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RevocationReason Reason { get; set; }
    }
}
