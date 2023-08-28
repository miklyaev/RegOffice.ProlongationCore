using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица скидок для тарифа в прайсе
    /// </summary>
    public partial class TariffDiscount
    {
        public TariffDiscount()
        {
            KcrIssues = new HashSet<KcrIssue>();
            TariffDiscountRules = new HashSet<TariffDiscountRule>();
        }


        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Секция
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffDiscountId { get; set; }

        /// <summary>
        /// Максимальное количество использований
        /// </summary>
        public int? UseLimit { get; set; }

        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual ICollection<KcrIssue> KcrIssues { get; set; }
        public virtual ICollection<TariffDiscountRule> TariffDiscountRules { get; set; }
    }
}
