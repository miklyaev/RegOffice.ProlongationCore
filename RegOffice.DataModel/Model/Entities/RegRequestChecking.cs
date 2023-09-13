using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestChecking
    {
        public RegRequestChecking()
        {
            RegRequestCheckingSteps = new HashSet<RegRequestCheckingStep>();
            RegRequestPassportCheckings = new HashSet<RegRequestPassportChecking>();
        }

        public int CheckingId { get; set; }
        public int RegRequestId { get; set; }
        public int CheckingTypeId { get; set; }
        public DateTime CheckingTime { get; set; }
        public string Message { get; set; }
        public int? MemberId { get; set; }
        public Guid? TaskId { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }
        public int? ContentId { get; set; }

        public virtual CheckingType CheckingType { get; set; }
        public virtual File Content { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RegRequestCheckingStep> RegRequestCheckingSteps { get; set; }
        public virtual ICollection<RegRequestPassportChecking> RegRequestPassportCheckings { get; set; }
    }
}
