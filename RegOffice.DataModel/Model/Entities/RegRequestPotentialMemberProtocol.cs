using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestPotentialMemberProtocol
    {
        public int RegRequestPotentialMemberProtocolId { get; set; }
        public int RegRequestPotentialMemberId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }

        public virtual Protocol Protocol { get; set; }
        public virtual RegRequestPotentialMember RegRequestPotentialMember { get; set; }
    }
}
