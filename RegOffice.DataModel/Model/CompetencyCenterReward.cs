using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CompetencyCenterReward
    {
        public int? AgentId { get; set; }
        public decimal? PercentReward { get; set; }
        public int? ContractTariffId { get; set; }
    }
}
