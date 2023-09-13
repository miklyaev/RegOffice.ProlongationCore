using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestMemberDssApp
    {
        public int MemberId { get; set; }
        public int AppId { get; set; }
        public bool? ForceAuthUpdate { get; set; }

        public virtual DssApp App { get; set; }
        public virtual RegRequestMember Member { get; set; }
    }
}
