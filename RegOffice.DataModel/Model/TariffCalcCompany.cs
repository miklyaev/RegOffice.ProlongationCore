using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица список компаний для тарифного калькулятора.
    /// </summary>
    public partial class TariffCalcCompany
    {
        public TariffCalcCompany()
        {
            TariffCalcTariffs = new HashSet<TariffCalcTariff>();
        }


        /// <summary>
        /// Id компании.
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// Имя компании.
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<TariffCalcTariff> TariffCalcTariffs { get; set; }
    }
}
