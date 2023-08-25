using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сертификатов
    /// </summary>
    public partial class Certificate
    {
        public Certificate()
        {
            InverseTrustCertificate = new HashSet<Certificate>();
            Keys = new HashSet<Key>();
            Offices = new HashSet<Office>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Общее имя
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Отпечаток
        /// </summary>
        public string ThumbPrint { get; set; }

        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string SubjectKeyId { get; set; }

        /// <summary>
        /// Идентификатор ключа издателя
        /// </summary>
        public string AuthorityKeyId { get; set; }

        /// <summary>
        /// Общее имя издателя
        /// </summary>
        public string IssuerCommonName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int CertificateTypeId { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid CertificateGuid { get; set; }

        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateTime InitialTime { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Корневой
        /// </summary>
        public int? TrustCertificateId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Печатная форма расписки
        /// </summary>
        public int? ReceiptId { get; set; }

        public virtual Certificate TrustCertificate { get; set; }
        public virtual ICollection<Certificate> InverseTrustCertificate { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
