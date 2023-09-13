using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class GateUpdater
    {
        public int GateUpdaterId { get; set; }
        public Guid GateId { get; set; }
        public int EntityTypeId { get; set; }
        public Guid EntityGuid { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? ConfirmTime { get; set; }

        public virtual EntityType EntityType { get; set; }
        public virtual Gate Gate { get; set; }
    }
}
