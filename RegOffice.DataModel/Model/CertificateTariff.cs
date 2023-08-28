using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица услуг УЦ
    /// </summary>
    public partial class CertificateTariff
    {
        public CertificateTariff()
        {
            CertificateTariffSteps = new HashSet<CertificateTariffStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateTariffId { get; set; }

        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateTariffStep> CertificateTariffSteps { get; set; }
    }
}
