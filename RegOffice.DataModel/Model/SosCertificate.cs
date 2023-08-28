using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов СОС
    /// </summary>
    public partial class SosCertificate
    {

        /// <summary>
        /// СОС
        /// </summary>
        public int SosId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual So Sos { get; set; }
    }
}
