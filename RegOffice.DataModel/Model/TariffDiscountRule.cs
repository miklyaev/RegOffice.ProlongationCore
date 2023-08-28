using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица зависимости скидки от наличия определенного тарифа
    /// </summary>
    public partial class TariffDiscountRule
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RuleId { get; set; }

        /// <summary>
        /// Cкидка для тарифа в прайсе
        /// </summary>
        public int TariffDiscountId { get; set; }

        /// <summary>
        /// Секция
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual TariffDiscount TariffDiscount { get; set; }
    }
}
