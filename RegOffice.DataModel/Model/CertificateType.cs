using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов сертификатов
    /// </summary>
    public partial class CertificateType
    {
        public CertificateType()
        {
            Certificates = new HashSet<Certificate>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CertificateTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CertificateTypeName { get; set; }

        public virtual ICollection<Certificate> Certificates { get; set; }
    }
}
