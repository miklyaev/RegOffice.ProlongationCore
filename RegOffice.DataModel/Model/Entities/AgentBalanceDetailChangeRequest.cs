using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalanceDetailChangeRequest
    {
        public AgentBalanceDetailChangeRequest()
        {
            AgentBalanceDetailChangeRequestComments = new HashSet<AgentBalanceDetailChangeRequestComment>();
            AgentBalanceDetailChangeRequestSteps = new HashSet<AgentBalanceDetailChangeRequestStep>();
        }

        public int BalanceDetailChangeRequestId { get; set; }
        public int BalanceDetailId { get; set; }
        public decimal StartPrice { get; set; }
        public decimal? RequestPrice { get; set; }
        public decimal? FinalPrice { get; set; }
        public bool ToDelete { get; set; }
        public int? DiscountId { get; set; }
        public int UserId { get; set; }
        public int StepId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime CreationTime { get; set; }

        public virtual AgentBalanceDetail BalanceDetail { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestComment> AgentBalanceDetailChangeRequestComments { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestStep> AgentBalanceDetailChangeRequestSteps { get; set; }
    }
}
