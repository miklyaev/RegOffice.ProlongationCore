using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица регистрации запросов на сертификаты
    /// </summary>
    public partial class RegCertRequest
    {
        public RegCertRequest()
        {
            RegCertRequestSteps = new HashSet<RegCertRequestStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegCertRequestId { get; set; }

        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int CertRequestId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string SubjectKeyId { get; set; }

        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }

        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string PackId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CertTemplate CertTemplate { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Office Office { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<RegCertRequestStep> RegCertRequestSteps { get; set; }
    }
}
