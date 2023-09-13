using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class IssuerAccreditation
    {
        public int IssuerAccreditationId { get; set; }
        public int IssuerId { get; set; }
        public DateTime? ReceivedAt { get; set; }
        public DateTime? RevokedAt { get; set; }

        public virtual Issuer Issuer { get; set; }
    }
}
