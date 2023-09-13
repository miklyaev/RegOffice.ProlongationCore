using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceOffice
    {
        public int BalanceOfficeId { get; set; }
        public int BalanceId { get; set; }
        public int OfficeId { get; set; }
        public DateTime? OfficeAcceptDate { get; set; }

        public virtual AgentBalance Balance { get; set; }
        public virtual Office Office { get; set; }
    }
}
