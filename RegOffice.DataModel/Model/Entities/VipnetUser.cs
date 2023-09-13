using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class VipnetUser
    {
        public VipnetUser()
        {
            Keys = new HashSet<Key>();
        }

        public string VipnetUserId { get; set; }
        public string VipnetUserName { get; set; }
        public string VipnetNodeId { get; set; }

        public virtual VipnetNode VipnetNode { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
    }
}
