using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица УЦ атрибутов шаблонов тарифа
    /// </summary>
    public partial class TariffAttributeCa
    {

        /// <summary>
        /// ИД атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }

        /// <summary>
        /// ИД УЦ
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// УЦ используется по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// ИД шаблона для УЦ
        /// </summary>
        public int? CaTemplateId { get; set; }

        /// <summary>
        /// ИД УЦ атрибута шаблона тарифа
        /// </summary>
        public int TariffAttributeCaId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CaTemplate CaTemplate { get; set; }
        public virtual TariffAttribute TariffAttribute { get; set; }
    }
}
