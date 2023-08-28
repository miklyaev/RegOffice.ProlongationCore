using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связей идентификаторов тарифов торговых площадок с внутренними тарифами
    /// </summary>
    public partial class TradingPlatformTariffAttribute
    {
        public TradingPlatformTariffAttribute()
        {
            TradingPlatformRegistrationRequests = new HashSet<TradingPlatformRegistrationRequest>();
        }


        /// <summary>
        /// Идентификатор внутреннего атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }

        /// <summary>
        /// Идентификатор тарифа в торговой площадке
        /// </summary>
        public string TradingPlatformExternalTariffId { get; set; }

        public virtual TariffAttribute TariffAttribute { get; set; }
        public virtual ICollection<TradingPlatformRegistrationRequest> TradingPlatformRegistrationRequests { get; set; }
    }
}
