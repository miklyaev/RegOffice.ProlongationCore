using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentScheme
    {
        public AgentScheme()
        {
            BonusSchemes = new HashSet<BonusScheme>();
            CaServices = new HashSet<CaService>();
            OfficeSchemes = new HashSet<OfficeScheme>();
            PlanSchemes = new HashSet<PlanScheme>();
            RewardOptions = new HashSet<RewardOption>();
        }

        public int AgentId { get; set; }
        public int ProductTypeId { get; set; }
        public int LevelId { get; set; }
        public bool? Dealer { get; set; }
        public int? ParentId { get; set; }
        public decimal? PercentReward { get; set; }
        public int? TransferPointId { get; set; }
        public int? PriceId { get; set; }
        public int SchemeId { get; set; }
        public int? RegionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual AgentLevel Level { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual Price Price { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Point TransferPoint { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BonusScheme> BonusSchemes { get; set; }
        public virtual ICollection<CaService> CaServices { get; set; }
        public virtual ICollection<OfficeScheme> OfficeSchemes { get; set; }
        public virtual ICollection<PlanScheme> PlanSchemes { get; set; }
        public virtual ICollection<RewardOption> RewardOptions { get; set; }
    }
}
