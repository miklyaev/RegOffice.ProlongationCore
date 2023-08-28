using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CertificateService
    {
        public CertificateService()
        {
            CertificateServiceSettings = new HashSet<CertificateServiceSetting>();
            CertificateServiceSteps = new HashSet<CertificateServiceStep>();
        }


        /// <summary>
        /// Ид. сертификата
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Тип сертивиса
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Ид. сервиса
        /// </summary>
        public int CertificateServiceId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateServiceSetting> CertificateServiceSettings { get; set; }
        public virtual ICollection<CertificateServiceStep> CertificateServiceSteps { get; set; }
    }
}
