using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп продуктов сверки
    /// </summary>
    public partial class AgentBalanceGroup
    {
        public AgentBalanceGroup()
        {
            AgentBalanceBills = new HashSet<AgentBalanceBill>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            BalanceBuildTasks = new HashSet<BalanceBuildTask>();
        }


        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public int AgentBalanceGroupId { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string AgentBalanceGroupName { get; set; }

        public virtual AgentBalanceProcessing AgentBalanceProcessing { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<BalanceBuildTask> BalanceBuildTasks { get; set; }
    }
}
