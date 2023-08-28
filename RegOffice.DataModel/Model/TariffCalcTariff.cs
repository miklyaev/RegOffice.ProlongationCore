using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица список тарифов для тарифного калькулятора.
    /// </summary>
    public partial class TariffCalcTariff
    {
        public TariffCalcTariff()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrice>();
            Features = new HashSet<TariffCalcFeaturesList>();
            OrgNals = new HashSet<TariffCalcOrgNalType>();
            Regions = new HashSet<Region>();
        }


        /// <summary>
        /// Id тарифа
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Имя тарифа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id компании
        /// </summary>
        public int? Company { get; set; }

        /// <summary>
        /// Доступные для тарифа направления.
        /// </summary>
        public string Directions { get; set; }

        public virtual TariffCalcCompany CompanyNavigation { get; set; }
        public virtual ICollection<TariffCalcPrice> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcFeaturesList> Features { get; set; }
        public virtual ICollection<TariffCalcOrgNalType> OrgNals { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
