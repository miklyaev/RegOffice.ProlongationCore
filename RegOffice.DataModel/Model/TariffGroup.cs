using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп тарифов
    /// </summary>
    public partial class TariffGroup
    {
        public TariffGroup()
        {
            Tariffs = new HashSet<Tariff>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffGroupId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffGroupName { get; set; }

        public virtual ICollection<Tariff> Tariffs { get; set; }
    }
}
