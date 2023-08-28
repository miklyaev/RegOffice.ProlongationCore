using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class AstralWorkflowClient
    {
        public Guid WorkflowGuid { get; set; }
        public int? AbonentId { get; set; }
        public DateOnly? CreateDate { get; set; }
        public int? LastRegRequestId { get; set; }
        public int? CertificateId { get; set; }
        public Guid? GateGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual RegRequest LastRegRequest { get; set; }
    }
}
