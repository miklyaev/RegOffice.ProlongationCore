using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица услуг прайсов
    /// </summary>
    public partial class PriceTariff
    {
        public PriceTariff()
        {
            ContractTariffs = new HashSet<ContractTariff>();
            KcrIssues = new HashSet<KcrIssue>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }


        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegisteredName { get; set; }

        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Показывать
        /// </summary>
        public bool? Displayed { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Идентификатор позиции в прайсе
        /// </summary>
        public Guid PriceTariffId { get; set; }
        public string Note { get; set; }

        /// <summary>
        /// Краткое описание тарифа
        /// </summary>
        public string ShortNote { get; set; }

        /// <summary>
        /// Маркетинговое название
        /// </summary>
        public string MarketingName { get; set; }

        public virtual PriceSection Section { get; set; }
        public virtual Step Step { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
