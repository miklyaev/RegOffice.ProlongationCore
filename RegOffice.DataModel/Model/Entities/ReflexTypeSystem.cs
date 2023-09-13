using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ReflexTypeSystem
    {
        public int ReflexTypeSystemId { get; set; }
        public int ReflexTypeId { get; set; }
        public int SystemId { get; set; }

        public virtual ReflexType ReflexType { get; set; }
        public virtual UpdateSystem System { get; set; }
    }
}
