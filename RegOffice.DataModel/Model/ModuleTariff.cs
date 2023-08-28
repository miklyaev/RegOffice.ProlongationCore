using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Тарифы для модуля
    /// </summary>
    public partial class ModuleTariff
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ModuleTariffId { get; set; }

        /// <summary>
        /// Модуль
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        public virtual Module Module { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}
