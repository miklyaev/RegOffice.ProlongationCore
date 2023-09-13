using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AttributeDocumentType
    {
        public int AttributeId { get; set; }
        public int DocTypeId { get; set; }
        public bool OnlyForProxy { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual DocType DocType { get; set; }
    }
}
