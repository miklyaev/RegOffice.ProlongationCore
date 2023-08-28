using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица секций прайсов
    /// </summary>
    public partial class PriceSection
    {
        public PriceSection()
        {
            InverseParentSection = new HashSet<PriceSection>();
            ContractTariffs = new HashSet<ContractTariff>();
            PriceTariffSteps = new HashSet<PriceTariffStep>();
            PriceTariffs = new HashSet<PriceTariff>();
            PriceTrends = new HashSet<PriceTrend>();
            RegRequestTariffs = new HashSet<RegRequestTariff>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string SectionName { get; set; }

        /// <summary>
        /// Родительская секция
        /// </summary>
        public int? ParentSectionId { get; set; }

        public virtual PriceSection ParentSection { get; set; }
        public virtual Price Price { get; set; }
        public virtual ICollection<PriceSection> InverseParentSection { get; set; }
        public virtual ICollection<ContractTariff> ContractTariffs { get; set; }
        public virtual ICollection<PriceTariffStep> PriceTariffSteps { get; set; }
        public virtual ICollection<PriceTariff> PriceTariffs { get; set; }
        public virtual ICollection<PriceTrend> PriceTrends { get; set; }
        public virtual ICollection<RegRequestTariff> RegRequestTariffs { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
