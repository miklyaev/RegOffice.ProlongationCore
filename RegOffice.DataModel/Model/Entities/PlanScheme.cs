using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PlanScheme
    {
        public int PlanId { get; set; }
        public int SchemeId { get; set; }

        public virtual Plan Plan { get; set; }
        public virtual AgentScheme Scheme { get; set; }
    }
}
