using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class License
    {
        public License()
        {
            LicenseSteps = new HashSet<LicenseStep>();
        }

        public int LicenseId { get; set; }
        public int ProductId { get; set; }
        public int LicenseTypeId { get; set; }
        public Guid LicenseGuid { get; set; }
        public bool IsActual { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? UserId { get; set; }
        public int? TimeLimit { get; set; }
        public int StepId { get; set; }

        public virtual LicenseType LicenseType { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<LicenseStep> LicenseSteps { get; set; }
    }
}
