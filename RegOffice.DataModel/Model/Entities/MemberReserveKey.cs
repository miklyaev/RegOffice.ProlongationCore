using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MemberReserveKey
    {
        public int MemberId { get; set; }
        public int? ProviderId { get; set; }
        public string ContainerName { get; set; }
        public int? CaId { get; set; }
        public string SubjectKeyId { get; set; }
        public int? CertRequestId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual File CertRequest { get; set; }
        public virtual RegRequestMember Member { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
