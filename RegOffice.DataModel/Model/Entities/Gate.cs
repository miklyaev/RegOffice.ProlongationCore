using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Gate
    {
        public Gate()
        {
            GateProductTypes = new HashSet<GateProductType>();
            GateProtocols = new HashSet<GateProtocol>();
            GateSettings = new HashSet<GateSetting>();
            GateUpdaters = new HashSet<GateUpdater>();
            ProductNetNodes = new HashSet<ProductNetNode>();
            RegRequestGates = new HashSet<RegRequestGate>();
            TokenGates = new HashSet<TokenGate>();
            WorkflowServices = new HashSet<WorkflowService>();
        }

        public Guid GateId { get; set; }
        public string GateName { get; set; }
        public string Password { get; set; }
        public int? CertificateId { get; set; }
        public int? SystemId { get; set; }
        public bool IsVirtual { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual UpdateSystem System { get; set; }
        public virtual ICollection<GateProductType> GateProductTypes { get; set; }
        public virtual ICollection<GateProtocol> GateProtocols { get; set; }
        public virtual ICollection<GateSetting> GateSettings { get; set; }
        public virtual ICollection<GateUpdater> GateUpdaters { get; set; }
        public virtual ICollection<ProductNetNode> ProductNetNodes { get; set; }
        public virtual ICollection<RegRequestGate> RegRequestGates { get; set; }
        public virtual ICollection<TokenGate> TokenGates { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
