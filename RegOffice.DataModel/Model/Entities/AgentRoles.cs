using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentRoles
    {
        public int AgentGuid { get; set; }
        public int ViewRoleId { get; set; }

        public virtual Agents AgentGu { get; set; }
        public virtual Roles ViewRole { get; set; }
    }
}
