using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ограничений для тарифов
    /// </summary>
    public partial class TariffLimit
    {

        /// <summary>
        /// ИД тарифа
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// ИД ограничения
        /// </summary>
        public int LimitId { get; set; }

        /// <summary>
        /// Значение ограничения
        /// </summary>
        public string LimitValue { get; set; }

        public virtual Limit Limit { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
