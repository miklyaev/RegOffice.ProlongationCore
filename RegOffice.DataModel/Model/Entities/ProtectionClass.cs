using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProtectionClass
    {
        public ProtectionClass()
        {
            Keys = new HashSet<Key>();
        }

        public int ProtectionClassId { get; set; }
        public string ProtectionClassName { get; set; }
        public string PolicyOid { get; set; }

        public virtual ICollection<Key> Keys { get; set; }
    }
}
