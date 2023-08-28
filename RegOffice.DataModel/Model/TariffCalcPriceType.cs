using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Типы цен
    /// </summary>
    public partial class TariffCalcPriceType
    {
        public TariffCalcPriceType()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrice>();
        }


        /// <summary>
        /// Id типа цены
        /// </summary>
        public int PriceTypeId { get; set; }

        /// <summary>
        /// Описание типа цены
        /// </summary>
        public string PriceDesk { get; set; }

        public virtual ICollection<TariffCalcPrice> TariffCalcPrices { get; set; }
    }
}
