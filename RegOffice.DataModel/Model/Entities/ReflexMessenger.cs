using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ReflexMessenger
    {
        public int ReflexId { get; set; }
        public int ReflexTypeId { get; set; }
        public int MessengerId { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
    }
}
