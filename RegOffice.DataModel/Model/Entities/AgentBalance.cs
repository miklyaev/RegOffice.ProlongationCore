using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentBalance
    {
        public AgentBalance()
        {
            AgentBalanceBills = new HashSet<AgentBalanceBill>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentBalanceOffices = new HashSet<AgentBalanceOffice>();
        }

        public int BalanceId { get; set; }
        public int BalanceYear { get; set; }
        public int BalanceMonth { get; set; }
        public int AgentId { get; set; }
        public DateTime LastUnacceptDate { get; set; }
        public DateTime? PartnerAcceptDate { get; set; }
        public DateTime? SaleCenterAcceptDate { get; set; }
        public decimal PercentReward { get; set; }
        public DateTime? MercuryAcceptDate { get; set; }
        public decimal? MercuryAgentPercentReward { get; set; }
        public decimal? MercuryScPercentReward { get; set; }
        public DateTime? EtpAcceptDate { get; set; }
        public DateTime? EtpScAcceptDate { get; set; }
        public DateTime? EtpVendorAcceptDate { get; set; }
        public int? ParentId { get; set; }
        public decimal? EtpAgentPercentReward { get; set; }
        public DateTime? BillAcceptDate { get; set; }
        public DateTime? OfdBillAcceptDate { get; set; }
        public DateTime? EtpBillAcceptDate { get; set; }
        public decimal? Ao5AgentPercentReward { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<AgentBalanceOffice> AgentBalanceOffices { get; set; }
    }
}
