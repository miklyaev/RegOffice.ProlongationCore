using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний скидок прайсов
    /// </summary>
    public partial class PriceDiscountStep
    {

        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Price Price { get; set; }
        public virtual PriceDiscount PriceDiscount { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
