using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Coefficient
    {
        public int CoefficientId { get; set; }
        public int? CoefficientTypeId { get; set; }
        public double? Value { get; set; }
        public int? MerchandiseId { get; set; }
    }
}
