using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ObjectType
    {
        public ObjectType()
        {
            Objects = new HashSet<Object>();
            Transitions = new HashSet<Transition>();
        }

        public int ObjectTypeId { get; set; }
        public string ObjectTypeName { get; set; }

        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
