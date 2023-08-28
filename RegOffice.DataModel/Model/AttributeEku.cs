using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица расширений сертификата для атрибута
    /// </summary>
    public partial class AttributeEku
    {

        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Расширение
        /// </summary>
        public int EkuId { get; set; }

        /// <summary>
        /// Опциональный ОИД
        /// </summary>
        public bool IsPrimary { get; set; }
        public bool IsOptional { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Eku Eku { get; set; }
    }
}
