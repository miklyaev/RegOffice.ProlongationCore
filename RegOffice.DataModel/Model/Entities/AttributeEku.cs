using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AttributeEku
    {
        public int AttributeId { get; set; }
        public int EkuId { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsOptional { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Eku Eku { get; set; }
    }
}
