using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentReward
    {
        public int ContractTariffId { get; set; }
        public int AgentId { get; set; }
        public decimal PercentReward { get; set; }
        public decimal SumReward { get; set; }
        public int RewardId { get; set; }
        public int? BonusId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Bonus Bonus { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
    }
}
