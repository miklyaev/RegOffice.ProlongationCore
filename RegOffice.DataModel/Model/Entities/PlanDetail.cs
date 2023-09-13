using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PlanDetail
    {
        public int PlanId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int MinValue { get; set; }
        public int? MaxValue { get; set; }
        public decimal PercentReward { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
