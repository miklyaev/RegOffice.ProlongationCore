using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица для связи потенциального абонента и тарифа многие ко многим
    /// </summary>
    public partial class PotentialAbonentTariffAbonent
    {

        /// <summary>
        /// ID потенциального абонента
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// ID тарифа
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int? Count { get; set; }

        public virtual PotentialAbonentTariff Tariff { get; set; }
    }
}
