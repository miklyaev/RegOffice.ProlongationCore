using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPotentialMemberProtocol
    {
        public int ProductPotentialMemberProtocolId { get; set; }
        public int ProductPotentialMemberId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }

        public virtual ProductPotentialMember ProductPotentialMember { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
