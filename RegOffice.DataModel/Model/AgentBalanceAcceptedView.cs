using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AgentBalanceAcceptedView
    {
        public int? AgentId { get; set; }
        public string AgentName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public int? BalanceMonth { get; set; }
        public int? BalanceYear { get; set; }
        public long? NotAcceptedAmount { get; set; }
        public DateTime? AcceptedDate { get; set; }
    }
}
