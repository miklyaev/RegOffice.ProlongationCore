using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
