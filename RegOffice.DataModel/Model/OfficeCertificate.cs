using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов офиса
    /// </summary>
    public partial class OfficeCertificate
    {

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Office Office { get; set; }
    }
}
