using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentTradingPlatformType
    {
        public PotentialAbonentTradingPlatformType()
        {
            PotentialAbonentTradingPlatforms = new HashSet<PotentialAbonentTradingPlatform>();
        }

        public int TradingPlatformTypeId { get; set; }
        public string TradingPlatformName { get; set; }

        public virtual ICollection<PotentialAbonentTradingPlatform> PotentialAbonentTradingPlatforms { get; set; }
    }
}
