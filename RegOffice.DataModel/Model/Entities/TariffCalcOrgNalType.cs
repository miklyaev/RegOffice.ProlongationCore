using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffCalcOrgNalType
    {
        public TariffCalcOrgNalType()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrices>();
            TariffCalcTariffOrgNals = new HashSet<TariffCalcTariffOrgNal>();
        }

        public int OrgnalId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TariffCalcPrices> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcTariffOrgNal> TariffCalcTariffOrgNals { get; set; }
    }
}
