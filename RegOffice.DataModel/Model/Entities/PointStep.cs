using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PointStep
    {
        public int PointId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }

        public virtual Point Point { get; set; }
        public virtual Step Step { get; set; }
    }
}
