using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов тарифов
    /// </summary>
    public partial class TariffType
    {
        public TariffType()
        {
            Tariffs = new HashSet<Tariff>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int TariffTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffTypeName { get; set; }

        public virtual ICollection<Tariff> Tariffs { get; set; }
    }
}
