using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuthStep
    {
        public int Id { get; set; }
        public int AuthId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CheckTime { get; set; }

        public virtual DssAuth Auth { get; set; }
        public virtual Step Step { get; set; }
    }
}
