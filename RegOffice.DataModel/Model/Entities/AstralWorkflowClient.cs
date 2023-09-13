using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AstralWorkflowClient
    {
        public Guid WorkflowGuid { get; set; }
        public int? AbonentId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LastRegRequestId { get; set; }
        public int? CertificateId { get; set; }
        public Guid? GateGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RegRequest LastRegRequest { get; set; }
    }
}
