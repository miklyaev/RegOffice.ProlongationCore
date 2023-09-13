using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AddressObject
    {
        public AddressObject()
        {
            AddressAreas = new HashSet<Address>();
            AddressCities = new HashSet<Address>();
            AddressLocalities = new HashSet<Address>();
            AddressRegions = new HashSet<Address>();
            AddressStreets = new HashSet<Address>();
            InverseParent = new HashSet<AddressObject>();
        }

        public int AddressObjectId { get; set; }
        public int? ParentId { get; set; }
        public int PrefixId { get; set; }
        public string AddressObjectName { get; set; }
        public string AddressObjectCode { get; set; }
        public string PostalCode { get; set; }
        public string TaxCode { get; set; }
        public string AreaTaxCode { get; set; }
        public string Okato { get; set; }
        public int? Status { get; set; }

        public virtual AddressObject Parent { get; set; }
        public virtual AddressObjectPrefix Prefix { get; set; }
        public virtual ICollection<Address> AddressAreas { get; set; }
        public virtual ICollection<Address> AddressCities { get; set; }
        public virtual ICollection<Address> AddressLocalities { get; set; }
        public virtual ICollection<Address> AddressRegions { get; set; }
        public virtual ICollection<Address> AddressStreets { get; set; }
        public virtual ICollection<AddressObject> InverseParent { get; set; }
    }
}
