using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class PotentialAbonentCallState
    {
        public PotentialAbonentCallState()
        {
            PotentialAbonentCalls = new HashSet<PotentialAbonentCall>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<PotentialAbonentCall> PotentialAbonentCalls { get; set; }
    }
}
