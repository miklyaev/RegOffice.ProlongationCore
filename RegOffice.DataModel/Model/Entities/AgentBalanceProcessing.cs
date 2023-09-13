using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceProcessing
    {
        public int AgentBalanceGroupId { get; set; }
        public DateTime BlockTime { get; set; }

        public virtual AgentBalanceGroup AgentBalanceGroup { get; set; }
    }
}
