using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица запросов на сертификат
    /// </summary>
    public partial class CertificateRequest
    {
        public CertificateRequest()
        {
            CertificateRequestSteps = new HashSet<CertificateRequestStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateRequestId { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid CertificateRequestGuid { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateRequestStep> CertificateRequestSteps { get; set; }
    }
}
