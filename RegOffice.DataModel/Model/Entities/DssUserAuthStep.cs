using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssUserAuthStep
    {
        public int Id { get; set; }
        public int DssUserId { get; set; }
        public int? AuthStepId { get; set; }
        public DateTime LogTime { get; set; }

        public virtual Step AuthStep { get; set; }
        public virtual DssUser DssUser { get; set; }
    }
}
