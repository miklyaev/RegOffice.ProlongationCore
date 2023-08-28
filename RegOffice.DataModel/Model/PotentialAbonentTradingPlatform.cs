using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class PotentialAbonentTradingPlatform
    {

        /// <summary>
        /// Идентификатор торговой площадки
        /// </summary>
        public int AbonentPlatformId { get; set; }

        /// <summary>
        /// Идентификатор потенциального абонента
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// Идентификатор типа торговой площадки
        /// </summary>
        public int TradingPlatformTypeId { get; set; }

        /// <summary>
        /// Дата начала сертификата
        /// </summary>
        public DateTime InitialDate { get; set; }

        /// <summary>
        /// Дата окончания сертификата
        /// </summary>
        public DateTime EndDate { get; set; }

        public virtual PotentialAbonentTradingPlatformType TradingPlatformType { get; set; }
    }
}
