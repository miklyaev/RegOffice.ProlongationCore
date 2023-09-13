using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Condition
    {
        public Condition()
        {
            Transitions = new HashSet<Transition>();
        }

        public int ConditionId { get; set; }
        public Guid ConditionGuid { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
