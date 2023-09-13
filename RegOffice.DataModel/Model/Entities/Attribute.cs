using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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

        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int AttributeTypeId { get; set; }
        public Guid AttributeGuid { get; set; }
        public DateTime CreationTime { get; set; }

        public virtual AttributeType AttributeType { get; set; }
        public virtual ICollection<AttributeDocumentType> AttributeDocumentTypes { get; set; }
        public virtual ICollection<AttributeEku> AttributeEkus { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<RewardOption> RewardOptions { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
    }
}
