using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertTemplateProductType
    {
        public int CertTemplateId { get; set; }
        public int ProductTypeId { get; set; }
        public bool IsDefault { get; set; }

        public virtual CertTemplate CertTemplate { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
