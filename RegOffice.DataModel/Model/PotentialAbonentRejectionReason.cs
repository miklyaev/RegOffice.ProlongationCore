using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
