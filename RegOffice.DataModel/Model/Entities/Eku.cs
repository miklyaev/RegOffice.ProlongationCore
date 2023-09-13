using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Eku
    {
        public Eku()
        {
            AttributeEkus = new HashSet<AttributeEku>();
            CertTemplateEkus = new HashSet<CertTemplateEku>();
            ProductPersonEkus = new HashSet<ProductPersonEku>();
            RegRequestMemberEkus = new HashSet<RegRequestMemberEku>();
        }

        public int EkuId { get; set; }
        public string EkuName { get; set; }
        public string EkuOid { get; set; }
        public bool Required { get; set; }

        public virtual ICollection<AttributeEku> AttributeEkus { get; set; }
        public virtual ICollection<CertTemplateEku> CertTemplateEkus { get; set; }
        public virtual ICollection<ProductPersonEku> ProductPersonEkus { get; set; }
        public virtual ICollection<RegRequestMemberEku> RegRequestMemberEkus { get; set; }
    }
}
