using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Цены тарифов и доп. возможностей в сложном формате.
    /// </summary>
    public partial class TariffCalcComplexPrice
    {

        /// <summary>
        /// Id цены которой принаджлежат условия
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Описание части сложной цены
        /// </summary>
        public string Desk { get; set; }

        /// <summary>
        /// Цена части сложной цены
        /// </summary>
        public decimal Price { get; set; }

        public virtual TariffCalcPrice PriceNavigation { get; set; }
    }
}
