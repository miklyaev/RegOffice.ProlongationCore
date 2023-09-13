using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Bonus
    {
        public Bonus()
        {
            AgentRewards = new HashSet<AgentReward>();
            BonusSchemes = new HashSet<BonusScheme>();
        }

        public int BonusId { get; set; }
        public int BonusTypeId { get; set; }
        public string BonusName { get; set; }
        public bool? Percent { get; set; }
        public decimal? BonusValue { get; set; }
        public int? MinNumber { get; set; }
        public int? MaxNumber { get; set; }

        public virtual BonusType BonusType { get; set; }
        public virtual ICollection<AgentReward> AgentRewards { get; set; }
        public virtual ICollection<BonusScheme> BonusSchemes { get; set; }
    }
}
