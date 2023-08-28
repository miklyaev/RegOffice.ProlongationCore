using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица услуг заявлений
    /// </summary>
    public partial class RegRequestTariff
    {

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Секция прайса
        /// </summary>
        public int? SectionId { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? EndDate { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly? StartDate { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal? Price { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
