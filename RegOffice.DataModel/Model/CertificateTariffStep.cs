using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний услуг УЦ
    /// </summary>
    public partial class CertificateTariffStep
    {

        /// <summary>
        /// Услуга УЦ
        /// </summary>
        public int CertificateTariffId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual CertificateTariff CertificateTariff { get; set; }
        public virtual Step Step { get; set; }
    }
}
