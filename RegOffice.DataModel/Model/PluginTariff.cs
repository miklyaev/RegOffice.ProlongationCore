using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тарифов для плагинов
    /// </summary>
    public partial class PluginTariff
    {
        public PluginTariff()
        {
            MercuryPlugins = new HashSet<MercuryPlugin>();
            Plugins = new HashSet<Plugin>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Плагин
        /// </summary>
        public int PluginId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffName { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int? ProtocolId { get; set; }

        public virtual Plugin Plugin { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual ICollection<MercuryPlugin> MercuryPlugins { get; set; }
        public virtual ICollection<Plugin> Plugins { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
    }
}
