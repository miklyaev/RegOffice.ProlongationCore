using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestPotentialMember
    {
        public RegRequestPotentialMember()
        {
            RegRequestPotentialMemberProtocols = new HashSet<RegRequestPotentialMemberProtocol>();
        }

        public int RegRequestPotentialMemberId { get; set; }
        public int RegRequestId { get; set; }
        public string Email { get; set; }
        public string Snils { get; set; }
        public bool? IsAdministrator { get; set; }
        public bool Unregister { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual ICollection<RegRequestPotentialMemberProtocol> RegRequestPotentialMemberProtocols { get; set; }
    }
}
