using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class GateProtocol
    {
        public int GateProtocolId { get; set; }
        public Guid GateId { get; set; }
        public int ProtocolId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
