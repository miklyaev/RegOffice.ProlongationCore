using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тарифных зон
    /// </summary>
    public partial class TariffZone
    {
        public TariffZone()
        {
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            Contracts = new HashSet<Contract>();
            PriceSchemes = new HashSet<PriceScheme>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int TariffZoneId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffZoneName { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }

        public virtual Price PriceNavigation { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<PriceScheme> PriceSchemes { get; set; }
    }
}
