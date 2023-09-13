using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPinType
    {
        public OfdPinType()
        {
            OfdPinTemplates = new HashSet<OfdPinTemplate>();
            OfdPins = new HashSet<OfdPin>();
        }

        public int OfdPinTypeId { get; set; }
        public string RoOfdPinTypeName { get; set; }

        public virtual ICollection<OfdPinTemplate> OfdPinTemplates { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
