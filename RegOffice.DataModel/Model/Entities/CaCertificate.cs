using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaCertificate
    {
        public int CaId { get; set; }
        public int CertificateId { get; set; }
        public DateTime LogTime { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}
