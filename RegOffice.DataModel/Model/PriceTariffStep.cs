using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний услуг прайсов
    /// </summary>
    public partial class PriceTariffStep
    {

        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }

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

        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }

        public virtual PriceTariff PriceTariff { get; set; }
        public virtual PriceSection Section { get; set; }
        public virtual Step Step { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual User User { get; set; }
    }
}
