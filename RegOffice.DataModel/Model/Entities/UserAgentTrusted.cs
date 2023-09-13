using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UserAgentTrusted
    {
        public int UserId { get; set; }
        public int AgentId { get; set; }
        public bool? IsTrusted { get; set; }
        public Guid ProductGuid { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual User User { get; set; }
    }
}
