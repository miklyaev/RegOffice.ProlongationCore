using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов получателей
    /// </summary>
    public partial class RecipientCertificate
    {

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int? Index { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
