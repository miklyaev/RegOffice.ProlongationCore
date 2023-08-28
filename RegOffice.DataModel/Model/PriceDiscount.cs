using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица скидок прайса
    /// </summary>
    public partial class PriceDiscount
    {
        public PriceDiscount()
        {
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
        }


        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string RegisteredName { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }

        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Price Price { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
    }
}
