using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContractStep
    {
        public int ContractId { get; set; }
        public int StepId { get; set; }
        public DateTime LogTime { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
