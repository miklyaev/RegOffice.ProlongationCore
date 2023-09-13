using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestMemberAvailableProtocol
    {
        public int MemberId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }
        public int RegRequestMemberAvailableProtocolId { get; set; }

        public virtual RegRequestMember Member { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
