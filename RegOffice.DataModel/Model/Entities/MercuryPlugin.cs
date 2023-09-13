using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MercuryPlugin
    {
        public int MercuryPluginId { get; set; }
        public int MercuryId { get; set; }
        public int PluginId { get; set; }
        public int? TariffId { get; set; }

        public virtual Product Mercury { get; set; }
        public virtual Plugin Plugin { get; set; }
        public virtual PluginTariff PluginTariff { get; set; }
    }
}
