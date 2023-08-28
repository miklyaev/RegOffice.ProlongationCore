using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица шаблонов сертификатов
    /// </summary>
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


        /// <summary>
        /// Код
        /// </summary>
        public int CertTemplateId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
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
