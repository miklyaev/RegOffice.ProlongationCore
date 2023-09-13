using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public int ProductId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceNumber { get; set; }
        public int? ProductPersonId { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
