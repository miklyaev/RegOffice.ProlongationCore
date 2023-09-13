using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcComplexPrices
    {
        public int PriceId { get; set; }
        public string Desk { get; set; }
        public decimal Price { get; set; }

        public virtual TariffCalcPrices PriceNavigation { get; set; }
    }
}
