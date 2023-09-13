using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            Certificates = new HashSet<Certificate>();
        }

        public int CertificateTypeId { get; set; }
        public string CertificateTypeName { get; set; }

        public virtual ICollection<Certificate> Certificates { get; set; }
    }
}
