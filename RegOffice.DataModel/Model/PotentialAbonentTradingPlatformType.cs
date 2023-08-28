using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class PotentialAbonentTradingPlatformType
    {
        public PotentialAbonentTradingPlatformType()
        {
            PotentialAbonentTradingPlatforms = new HashSet<PotentialAbonentTradingPlatform>();
        }


        /// <summary>
        /// Идентификатор типа торговой площадки
        /// </summary>
        public int TradingPlatformTypeId { get; set; }

        /// <summary>
        /// Наименование торговой площадки
        /// </summary>
        public string TradingPlatformName { get; set; }

        public virtual ICollection<PotentialAbonentTradingPlatform> PotentialAbonentTradingPlatforms { get; set; }
    }
}
