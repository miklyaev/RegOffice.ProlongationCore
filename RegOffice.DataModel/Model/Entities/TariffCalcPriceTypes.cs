using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcPriceTypes
    {
        public TariffCalcPriceTypes()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrices>();
        }

        public int PriceTypeId { get; set; }
        public string PriceDesk { get; set; }

        public virtual ICollection<TariffCalcPrices> TariffCalcPrices { get; set; }
    }
}
