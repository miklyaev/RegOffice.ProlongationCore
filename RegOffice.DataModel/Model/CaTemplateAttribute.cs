using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица атрибутов шаблонов УЦ
    /// </summary>
    public partial class CaTemplateAttribute
    {

        /// <summary>
        /// Шаблон УЦ
        /// </summary>
        public int CaTemplateId { get; set; }

        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }

        /// <summary>
        /// Ед. времени срока
        /// </summary>
        public int? ValidityUnitId { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual CaTemplate CaTemplate { get; set; }
        public virtual Unit ValidityUnit { get; set; }
    }
}
