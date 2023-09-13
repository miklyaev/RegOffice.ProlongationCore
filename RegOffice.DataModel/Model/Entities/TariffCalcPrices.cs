using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcPrices
    {
        public TariffCalcPrices()
        {
            TariffCalcComplexPrices = new HashSet<TariffCalcComplexPrices>();
        }

        public int PriceId { get; set; }
        public int PriceTypeId { get; set; }
        public int? TariffId { get; set; }
        public int? FeatureId { get; set; }
        public int RegionId { get; set; }
        public int OrgNalId { get; set; }
        public decimal? Price { get; set; }

        public virtual TariffCalcFeaturesList Feature { get; set; }
        public virtual TariffCalcOrgNalType OrgNal { get; set; }
        public virtual TariffCalcPriceTypes PriceType { get; set; }
        public virtual Region Region { get; set; }
        public virtual TariffCalcTariffs Tariff { get; set; }
        public virtual ICollection<TariffCalcComplexPrices> TariffCalcComplexPrices { get; set; }
    }
}
