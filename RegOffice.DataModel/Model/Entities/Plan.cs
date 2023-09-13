using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Plan
    {
        public Plan()
        {
            PlanDetails = new HashSet<PlanDetail>();
            PlanSchemes = new HashSet<PlanScheme>();
        }

        public int PlanId { get; set; }
        public string PlanName { get; set; }

        public virtual ICollection<PlanDetail> PlanDetails { get; set; }
        public virtual ICollection<PlanScheme> PlanSchemes { get; set; }
    }
}
