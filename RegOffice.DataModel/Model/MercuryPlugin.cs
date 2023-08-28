using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица плагинов АстралОтчет
    /// </summary>
    public partial class MercuryPlugin
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MercuryPluginId { get; set; }

        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }

        /// <summary>
        /// Плагин
        /// </summary>
        public int PluginId { get; set; }

        /// <summary>
        /// Тариф
        /// </summary>
        public int? TariffId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Plugin Plugin { get; set; }
        public virtual PluginTariff PluginTariff { get; set; }
    }
}
