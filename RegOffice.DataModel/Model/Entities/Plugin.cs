using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Plugin
    {
        public Plugin()
        {
            MercuryPlugins = new HashSet<MercuryPlugin>();
            PluginTariffs = new HashSet<PluginTariff>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
        }

        public int PluginId { get; set; }
        public string PluginName { get; set; }
        public Guid PluginGuid { get; set; }
        public int? ProtocolId { get; set; }
        public DateTime CreationTime { get; set; }
        public bool? Basic { get; set; }
        public int? DefaultTariffId { get; set; }

        public virtual PluginTariff PluginTariff { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual ICollection<MercuryPlugin> MercuryPlugins { get; set; }
        public virtual ICollection<PluginTariff> PluginTariffs { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
    }
}
