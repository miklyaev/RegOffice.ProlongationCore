using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class GateProductType
    {
        public int GateProductTypeId { get; set; }
        public Guid GateId { get; set; }
        public int ProductTypeId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
