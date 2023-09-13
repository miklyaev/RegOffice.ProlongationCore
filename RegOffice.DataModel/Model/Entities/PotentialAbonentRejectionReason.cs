using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentRejectionReason
    {
        public PotentialAbonentRejectionReason()
        {
            PotentialAbonentCalls = new HashSet<PotentialAbonentCall>();
        }

        public int ReasonId { get; set; }
        public string ReasonName { get; set; }

        public virtual ICollection<PotentialAbonentCall> PotentialAbonentCalls { get; set; }
    }
}
