using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AgentBalanceBill
    {

        /// <summary>
        /// Ид. баланса
        /// </summary>
        public int BalanceId { get; set; }

        /// <summary>
        /// Ид. счёта
        /// </summary>
        public int BillId { get; set; }

        /// <summary>
        /// Ид. группы
        /// </summary>
        public int BalanceGroupId { get; set; }

        public virtual AgentBalance Balance { get; set; }
        public virtual AgentBalanceGroup BalanceGroup { get; set; }
        public virtual SendedBill Bill { get; set; }
    }
}
