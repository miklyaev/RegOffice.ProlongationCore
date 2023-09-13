using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Merchandise
    {
        public Merchandise()
        {
            AgentMerchandises = new HashSet<AgentMerchandise>();
            BulkSkziLicenseUploadTasks = new HashSet<BulkSkziLicenseUploadTask>();
            MerchandiseBills = new HashSet<MerchandiseBill>();
            SkziLicenses = new HashSet<SkziLicense>();
        }

        public string MerchandiseSid { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public int? MeasureUnitCode { get; set; }
        public string UnitShortName { get; set; }
        public string UnitFullName { get; set; }
        public int MerchandiseId { get; set; }
        public int? MinCount { get; set; }
        public int? MaxCount { get; set; }
        public decimal Price { get; set; }
        public decimal NdsPercent { get; set; }
        public decimal? Weight { get; set; }
        public int? MerchandiseTypeId { get; set; }
        public int Reward { get; set; }
        public DateTime? OffTime { get; set; }
        public decimal? RewardOrdinary { get; set; }
        public decimal? ScPrice { get; set; }
        public decimal? ScReward { get; set; }

        public virtual MerchandiseType MerchandiseType { get; set; }
        public virtual ICollection<AgentMerchandise> AgentMerchandises { get; set; }
        public virtual ICollection<BulkSkziLicenseUploadTask> BulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<MerchandiseBill> MerchandiseBills { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
