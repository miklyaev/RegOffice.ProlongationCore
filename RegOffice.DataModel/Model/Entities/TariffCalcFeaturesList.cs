using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcFeaturesList
    {
        public TariffCalcFeaturesList()
        {
            TariffCalcFeatures = new HashSet<TariffCalcFeatures>();
            TariffCalcPrices = new HashSet<TariffCalcPrices>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }

        public virtual ICollection<TariffCalcFeatures> TariffCalcFeatures { get; set; }
        public virtual ICollection<TariffCalcPrices> TariffCalcPrices { get; set; }
    }
}
