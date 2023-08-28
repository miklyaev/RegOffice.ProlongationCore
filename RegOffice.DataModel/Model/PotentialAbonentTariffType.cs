using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица для типов тарифов
    /// </summary>
    public partial class PotentialAbonentTariffType
    {
        public PotentialAbonentTariffType()
        {
            PotentialAbonentTariffs = new HashSet<PotentialAbonentTariff>();
        }


        /// <summary>
        /// ID типа тарифа
        /// </summary>
        public int TariffTypeId { get; set; }

        /// <summary>
        /// Наименование типа тарифа
        /// </summary>
        public string TariffTypeName { get; set; }

        public virtual ICollection<PotentialAbonentTariff> PotentialAbonentTariffs { get; set; }
    }
}
