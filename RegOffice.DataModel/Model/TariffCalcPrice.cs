using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Цены тарифов
    /// </summary>
    public partial class TariffCalcPrice
    {
        public TariffCalcPrice()
        {
            TariffCalcComplexPrices = new HashSet<TariffCalcComplexPrice>();
        }


        /// <summary>
        /// Id цены
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Тип цены например для тарифа или для расширения
        /// </summary>
        public int PriceTypeId { get; set; }

        /// <summary>
        /// Id тарифа если цена для тарифа
        /// </summary>
        public int? TariffId { get; set; }

        /// <summary>
        /// Id возможности если цена для возможности 
        /// </summary>
        public int? FeatureId { get; set; }

        /// <summary>
        /// id региона
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Доступ или тип налогоорганизации для которой доступен тариф
        /// </summary>
        public int OrgNalId { get; set; }

        /// <summary>
        /// Цена в нормальном формате
        /// </summary>
        public decimal? Price { get; set; }

        public virtual TariffCalcFeaturesList Feature { get; set; }
        public virtual TariffCalcOrgNalType OrgNal { get; set; }
        public virtual TariffCalcPriceType PriceType { get; set; }
        public virtual Region Region { get; set; }
        public virtual TariffCalcTariff Tariff { get; set; }
        public virtual ICollection<TariffCalcComplexPrice> TariffCalcComplexPrices { get; set; }
    }
}
