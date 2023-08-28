using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов ЦС
    /// </summary>
    public partial class CaCertificate
    {

        /// <summary>
        /// Центр сертификации
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}
