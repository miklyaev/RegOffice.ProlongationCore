using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegCertRequestStep
    {
        public int RegCertRequestId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }

        public virtual RegCertRequest RegCertRequest { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
