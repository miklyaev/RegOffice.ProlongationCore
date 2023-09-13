using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UpdateSystem
    {
        public UpdateSystem()
        {
            Gates = new HashSet<Gate>();
            ReflexTypeSystems = new HashSet<ReflexTypeSystem>();
        }

        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public string SystemDescription { get; set; }

        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<ReflexTypeSystem> ReflexTypeSystems { get; set; }
    }
}
