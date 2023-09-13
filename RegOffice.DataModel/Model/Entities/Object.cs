using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Object
    {
        public Object()
        {
            Transitions = new HashSet<Transition>();
        }

        public int ObjectId { get; set; }
        public string ObjectName { get; set; }
        public int ObjectTypeId { get; set; }
        public string ObjectValue { get; set; }
        public int ValueTypeId { get; set; }

        public virtual ObjectType ObjectType { get; set; }
        public virtual ValueType ValueType { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
