using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OperatorIruc
    {
        public OperatorIruc()
        {
            MercuryMessengers = new HashSet<MercuryMessenger>();
            Offices = new HashSet<Office>();
        }

        public int OperatorIrucId { get; set; }
        public int CertificateId { get; set; }
        public int AgentId { get; set; }
        public string OperatorIrucName { get; set; }
        public string IrucLogin { get; set; }
        public string IrucPassword { get; set; }
        public int? SosId { get; set; }
        public int? DucId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Ca Duc { get; set; }
        public virtual Sos Sos { get; set; }
        public virtual ICollection<MercuryMessenger> MercuryMessengers { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
