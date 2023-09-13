using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceGroup
    {
        public AgentBalanceGroup()
        {
            AgentBalanceBills = new HashSet<AgentBalanceBill>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            BalanceBuildTasks = new HashSet<BalanceBuildTask>();
        }

        public int AgentBalanceGroupId { get; set; }
        public string AgentBalanceGroupName { get; set; }

        public virtual AgentBalanceProcessing AgentBalanceProcessing { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<BalanceBuildTask> BalanceBuildTasks { get; set; }
    }
}
