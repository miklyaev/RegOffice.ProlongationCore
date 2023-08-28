using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица плагинов заявлений на регистрацию
    /// </summary>
    public partial class RegRequestPlugin
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestPluginId { get; set; }

        /// <summary>
        /// Плагин
        /// </summary>
        public int RegRequestId { get; set; }
        public int PluginId { get; set; }

        /// <summary>
        /// Тариф
        /// </summary>
        public int? TariffId { get; set; }

        public virtual Plugin Plugin { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual PluginTariff PluginTariff { get; set; }
    }
}
