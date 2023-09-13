using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfficeDocType
    {
        public int OfficeDocTypeId { get; set; }
        public int OfficeId { get; set; }
        public int DocTypeId { get; set; }
        public bool Required { get; set; }
        public int? CertTemplateId { get; set; }

        public virtual CertTemplate CertTemplate { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual Office Office { get; set; }
    }
}
