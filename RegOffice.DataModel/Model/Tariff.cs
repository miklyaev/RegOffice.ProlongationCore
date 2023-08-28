using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тарифов
    /// </summary>
    public partial class Tariff
    {
        public Tariff()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            ContractTariffs = new HashSet<ContractTariff>();
            DssTariffs = new HashSet<DssTariff>();
            ModuleTariffs = new HashSet<ModuleTariff>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffAttributes = new HashSet<TariffAttribute>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
            TariffDiscounts = new HashSet<TariffDiscount>();
            TariffLimits = new HashSet<TariffLimit>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid TariffGuid { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TariffTypeId { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        public int TariffGroupId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Назначение тарифа
        /// </summary>
        public int? PurposeId { get; set; }

        public virtual TariffGroup TariffGroup { get; set; }
        public virtual TariffType TariffType { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<DssTariff> DssTariffs { get; set; }
        public virtual ICollection<ModuleTariff> ModuleTariffs { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
        public virtual ICollection<TariffLimit> TariffLimits { get; set; }
    }
}
