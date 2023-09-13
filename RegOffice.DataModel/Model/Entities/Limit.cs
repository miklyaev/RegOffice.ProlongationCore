using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Limit
    {
        public Limit()
        {
            OfdPinTemplateLimits = new HashSet<OfdPinTemplateLimit>();
            TariffAttributeLimits = new HashSet<TariffAttributeLimit>();
            TariffAttributes = new HashSet<TariffAttribute>();
            TariffLimits = new HashSet<TariffLimit>();
        }

        public int LimitId { get; set; }
        public string LimitName { get; set; }
        public Guid LimitGuid { get; set; }

        public virtual ICollection<OfdPinTemplateLimit> OfdPinTemplateLimits { get; set; }
        public virtual ICollection<TariffAttributeLimit> TariffAttributeLimits { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
        public virtual ICollection<TariffLimit> TariffLimits { get; set; }
    }
}
