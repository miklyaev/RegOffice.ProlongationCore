using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? CityId { get; set; }
        public int? LocalityId { get; set; }
        public int? StreetId { get; set; }
        public string PostalCode { get; set; }
        public string Building { get; set; }
        public string Bulk { get; set; }
        public string Flat { get; set; }

        public virtual AddressObject Area { get; set; }
        public virtual AddressObject City { get; set; }
        public virtual AddressObject Locality { get; set; }
        public virtual AddressObject Region { get; set; }
        public virtual AddressObject Street { get; set; }
    }
}
