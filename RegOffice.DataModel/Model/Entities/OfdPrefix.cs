using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfdPrefix
    {
        public OfdPrefix()
        {
            OfdPins = new HashSet<OfdPin>();
        }

        public int PrefixId { get; set; }
        public string Prefix { get; set; }
        public int AgentId { get; set; }
        public int PinLength { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
    }
}
