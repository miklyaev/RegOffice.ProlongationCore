using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Ra
    {
        public Ra()
        {
            RaSteps = new HashSet<RaStep>();
        }

        public int RaId { get; set; }
        public int CaId { get; set; }
        public string RaName { get; set; }
        public string FileMask { get; set; }
        public DateTime? LastSending { get; set; }
        public bool? Wmail { get; set; }
        public string Host { get; set; }
        public int? Port { get; set; }
        public int StepId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<RaStep> RaSteps { get; set; }
    }
}
