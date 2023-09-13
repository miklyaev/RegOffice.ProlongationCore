using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceBill
    {
        public int BalanceId { get; set; }
        public int BillId { get; set; }
        public int BalanceGroupId { get; set; }

        public virtual AgentBalance Balance { get; set; }
        public virtual AgentBalanceGroup BalanceGroup { get; set; }
        public virtual SendedBill Bill { get; set; }
    }
}
