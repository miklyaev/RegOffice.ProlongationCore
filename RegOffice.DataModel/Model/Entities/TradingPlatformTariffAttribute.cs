using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TradingPlatformTariffAttribute
    {
        public TradingPlatformTariffAttribute()
        {
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
        }

        public int TariffAttributeId { get; set; }
        public string TradingPlatformExternalTariffId { get; set; }

        public virtual TariffAttribute TariffAttribute { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
    }
}
