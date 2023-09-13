using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcTariffs
    {
        public TariffCalcTariffs()
        {
            TariffCalcFeatures = new HashSet<TariffCalcFeatures>();
            TariffCalcPrices = new HashSet<TariffCalcPrices>();
            TariffCalcTariffOrgNals = new HashSet<TariffCalcTariffOrgNal>();
            TariffCalcTariffRegions = new HashSet<TariffCalcTariffRegion>();
        }

        public int TariffId { get; set; }
        public string Name { get; set; }
        public int? Company { get; set; }
        public string Directions { get; set; }

        public virtual TariffCalcCompanies CompanyNavigation { get; set; }
        public virtual ICollection<TariffCalcFeatures> TariffCalcFeatures { get; set; }
        public virtual ICollection<TariffCalcPrices> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcTariffOrgNal> TariffCalcTariffOrgNals { get; set; }
        public virtual ICollection<TariffCalcTariffRegion> TariffCalcTariffRegions { get; set; }
    }
}
