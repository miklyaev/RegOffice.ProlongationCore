using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PluginTariff
    {
        public PluginTariff()
        {
            MercuryPlugins = new HashSet<MercuryPlugin>();
            Plugins = new HashSet<Plugin>();
            RegRequestPlugins = new HashSet<RegRequestPlugin>();
        }

        public int TariffId { get; set; }
        public int PluginId { get; set; }
        public string TariffName { get; set; }
        public int? ProtocolId { get; set; }

        public virtual Plugin Plugin { get; set; }
        public virtual Protocol Protocol { get; set; }
        public virtual ICollection<MercuryPlugin> MercuryPlugins { get; set; }
        public virtual ICollection<Plugin> Plugins { get; set; }
        public virtual ICollection<RegRequestPlugin> RegRequestPlugins { get; set; }
    }
}
