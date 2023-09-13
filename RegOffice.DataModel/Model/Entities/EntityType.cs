using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class EntityType
    {
        public EntityType()
        {
            GateUpdaters = new HashSet<GateUpdater>();
        }

        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GateUpdater> GateUpdaters { get; set; }
    }
}
