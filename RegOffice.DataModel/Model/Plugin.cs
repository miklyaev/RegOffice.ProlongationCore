using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица версий БД
    /// </summary>
    public partial class Plugin
    {
        public Plugin()
        {
            MercuryPlugins = new HashSet<MercuryPlugin>();
            PluginTariffs = new HashSet<PluginTariff>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int PluginId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PluginName { get; set; }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid PluginGuid { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int? ProtocolId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Основной
        /// </summary>
        public bool? Basic { get; set; }

        /// <summary>
        /// Тариф по умолчанию
        /// </summary>
        public int? DefaultTariffId { get; set; }

        public virtual Protocol Protocol { get; set; }
        public virtual PluginTariff PluginTariff { get; set; }
        public virtual ICollection<MercuryPlugin> MercuryPlugins { get; set; }
        public virtual ICollection<PluginTariff> PluginTariffs { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
    }
}
