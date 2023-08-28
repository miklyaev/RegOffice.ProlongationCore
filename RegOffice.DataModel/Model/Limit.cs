using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ограничений
    /// </summary>
    public partial class Limit
    {
        public Limit()
        {
            OfdPinTemplateLimits = new HashSet<OfdPinTemplateLimit>();
            TariffAttributeLimits = new HashSet<TariffAttributeLimit>();
            TariffAttributes = new HashSet<TariffAttribute>();
            TariffLimits = new HashSet<TariffLimit>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int LimitId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string LimitName { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid LimitGuid { get; set; }

        public virtual ICollection<OfdPinTemplateLimit> OfdPinTemplateLimits { get; set; }
        public virtual ICollection<TariffAttributeLimit> TariffAttributeLimits { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
        public virtual ICollection<TariffLimit> TariffLimits { get; set; }
    }
}
