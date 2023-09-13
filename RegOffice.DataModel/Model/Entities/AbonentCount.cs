using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonentCount
    {
        public int CountRecordId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public int? ProductTypeId { get; set; }
        public int? OfficeId { get; set; }
        public int ActiveAtStart { get; set; }
        public int ActiveAtEnd { get; set; }
        public int Connected { get; set; }
        public int Disconnected { get; set; }
        public int? Expired { get; set; }

        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
