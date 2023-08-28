using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний продуктов
    /// </summary>
    public partial class CertificateRequestStep
    {

        /// <summary>
        /// Продукт
        /// </summary>
        public int CertificateRequestId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int? NextStepId { get; set; }

        /// <summary>
        /// Ошибка
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Предыдущие состояние
        /// </summary>
        public int? PreviousStepId { get; set; }

        public virtual CertificateRequest CertificateRequest { get; set; }
        public virtual Step NextStep { get; set; }
        public virtual Step PreviousStep { get; set; }
        public virtual Step Step { get; set; }
    }
}
