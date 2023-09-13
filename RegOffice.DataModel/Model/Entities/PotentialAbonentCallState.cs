using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
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
