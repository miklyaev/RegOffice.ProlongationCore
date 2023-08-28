using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица список типов налогоорганизаций для тарифного калькулятора
    /// </summary>
    public partial class TariffCalcOrgNalType
    {
        public TariffCalcOrgNalType()
        {
            TariffCalcPrices = new HashSet<TariffCalcPrice>();
            Tariffs = new HashSet<TariffCalcTariff>();
        }


        /// <summary>
        /// Id типов налогоорганизаций.
        /// </summary>
        public int OrgnalId { get; set; }

        /// <summary>
        /// Описание типов налогоорганизаций
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<TariffCalcPrice> TariffCalcPrices { get; set; }
        public virtual ICollection<TariffCalcTariff> Tariffs { get; set; }
    }
}
