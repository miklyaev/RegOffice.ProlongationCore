using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Список возможностей
    /// </summary>
    public partial class TariffCalcFeaturesList
    {
        public TariffCalcFeaturesList()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrice>();
            Tariffs = new HashSet<TariffCalcTariff>();
        }


        /// <summary>
        /// Id возможности
        /// </summary>
        public int FeatureId { get; set; }

        /// <summary>
        /// Описание возможности
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Флаг основная возможность
        /// </summary>
        public bool IsMain { get; set; }

        public virtual ICollection<TariffCalcPrice> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcTariff> Tariffs { get; set; }
    }
}
