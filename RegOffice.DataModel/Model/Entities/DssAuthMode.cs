using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuthMode
    {
        public DssAuthMode()
        {
            DssUsers = new HashSet<DssUser>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int ModeId { get; set; }
        public string ModeName { get; set; }

        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
