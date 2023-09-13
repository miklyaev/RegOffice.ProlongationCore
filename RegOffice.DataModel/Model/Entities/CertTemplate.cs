using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertTemplate
    {
        public CertTemplate()
        {
            CertTemplateEkus = new HashSet<CertTemplateEku>();
            CertTemplateProductTypes = new HashSet<CertTemplateProductType>();
            Keys = new HashSet<Key>();
            OfficeDocTypes = new HashSet<OfficeDocType>();
            Offices = new HashSet<Office>();
            RegCertRequests = new HashSet<RegCertRequest>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int CertTemplateId { get; set; }
        public string CertTemplateName { get; set; }

        public virtual ICollection<CertTemplateEku> CertTemplateEkus { get; set; }
        public virtual ICollection<CertTemplateProductType> CertTemplateProductTypes { get; set; }
        public virtual ICollection<Key> Keys { get; set; }
        public virtual ICollection<OfficeDocType> OfficeDocTypes { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<RegCertRequest> RegCertRequests { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
