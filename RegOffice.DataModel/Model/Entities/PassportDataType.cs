using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PassportDataType
    {
        public PassportDataType()
        {
            ProductPassportCheckings = new HashSet<ProductPassportChecking>();
            RegRequestPassportCheckings = new HashSet<RegRequestPassportChecking>();
        }

        public int PassportDataTypeId { get; set; }
        public string PassportDataTypeName { get; set; }

        public virtual ICollection<ProductPassportChecking> ProductPassportCheckings { get; set; }
        public virtual ICollection<RegRequestPassportChecking> RegRequestPassportCheckings { get; set; }
    }
}
