using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов атрибутов
    /// </summary>
    public partial class AttributeType
    {
        public AttributeType()
        {
            Attributes = new HashSet<Attribute>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int AttributeTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AttributeTypeName { get; set; }

        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
