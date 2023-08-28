using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица скидок на покупки
    /// </summary>
    public partial class ContractTariffDiscount
    {

        /// <summary>
        /// Тариф по договору
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int? UserId { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual User User { get; set; }
    }
}
