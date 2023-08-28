using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// История цен
    /// </summary>
    public partial class PriceTrend
    {

        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }

        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Затраты
        /// </summary>
        public decimal? Cost { get; set; }

        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
