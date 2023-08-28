using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тарифов для серверов DSS
    /// </summary>
    public partial class DssTariff
    {

        /// <summary>
        /// Идентификатор сервера DSS
        /// </summary>
        public int DssId { get; set; }

        /// <summary>
        /// Идентификатор тарифа
        /// </summary>
        public int TariffId { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
