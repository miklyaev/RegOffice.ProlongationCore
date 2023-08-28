using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица тарифов 1С-ЭТП
    /// </summary>
    public partial class PotentialAbonentTariff
    {
        public PotentialAbonentTariff()
        {
            PotentialAbonentTariffAbonents = new HashSet<PotentialAbonentTariffAbonent>();
        }


        /// <summary>
        /// ID тарифа
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Наименование тарифа
        /// </summary>
        public string TariffName { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// ID типа тарифа
        /// </summary>
        public int TariffTypeId { get; set; }

        public virtual PotentialAbonentTariffType TariffType { get; set; }
        public virtual ICollection<PotentialAbonentTariffAbonent> PotentialAbonentTariffAbonents { get; set; }
    }
}
