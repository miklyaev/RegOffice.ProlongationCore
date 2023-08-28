using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ограничений для атрибутов тарифов
    /// </summary>
    public partial class TariffAttributeLimit
    {

        /// <summary>
        /// ИД атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }

        /// <summary>
        /// ИД ограничения
        /// </summary>
        public int LimitId { get; set; }

        /// <summary>
        /// Значение ограничения
        /// </summary>
        public string LimitValue { get; set; }

        public virtual Limit Limit { get; set; }
        public virtual TariffAttribute TariffAttribute { get; set; }
    }
}
