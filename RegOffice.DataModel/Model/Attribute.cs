using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица атрибутов (номенклатуры)
    /// </summary>
    public partial class Attribute
    {
        public Attribute()
        {
            AttributeDocumentTypes = new HashSet<AttributeDocumentType>();
            AttributeEkus = new HashSet<AttributeEku>();
            CaTemplateAttributes = new HashSet<CaTemplateAttribute>();
            RewardOptions = new HashSet<RewardOption>();
            TariffAttributes = new HashSet<TariffAttribute>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int AttributeTypeId { get; set; }

        /// <summary>
        /// Гуид
        /// </summary>
        public Guid AttributeGuid { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual AttributeType AttributeType { get; set; }
        public virtual ICollection<AttributeDocumentType> AttributeDocumentTypes { get; set; }
        public virtual ICollection<AttributeEku> AttributeEkus { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<RewardOption> RewardOptions { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
    }
}
