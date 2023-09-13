using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
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
