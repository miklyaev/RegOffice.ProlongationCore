using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Unit
    {
        public Unit()
        {
            CaTemplateAttributes = new HashSet<CaTemplateAttribute>();
            DssUserGroups = new HashSet<DssUserGroup>();
            OfdDevices = new HashSet<OfdDevice>();
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
            OfdPins = new HashSet<OfdPin>();
            TariffAttributes = new HashSet<TariffAttribute>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int UnitTypeId { get; set; }

        public virtual UnitType UnitType { get; set; }
        public virtual ICollection<CaTemplateAttribute> CaTemplateAttributes { get; set; }
        public virtual ICollection<DssUserGroup> DssUserGroups { get; set; }
        public virtual ICollection<OfdDevice> OfdDevices { get; set; }
        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<TariffAttribute> TariffAttributes { get; set; }
    }
}
