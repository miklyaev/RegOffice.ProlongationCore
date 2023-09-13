using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Addr
    {
        public Addr()
        {
            AbonentLocationAddresses = new HashSet<Abonent>();
            AbonentPostalAddresses = new HashSet<Abonent>();
            Orders = new HashSet<Order>();
            Points = new HashSet<Point>();
            ProductAbonentLocationAddresses = new HashSet<Product>();
            ProductAbonentPostalAddresses = new HashSet<Product>();
            RegBankRequests = new HashSet<RegBankRequest>();
            RegRequestLocationAddresses = new HashSet<RegRequest>();
            RegRequestPostalAddresses = new HashSet<RegRequest>();
        }

        public int AddrId { get; set; }
        public string PostalCode { get; set; }
        public int RegionId { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Bulk { get; set; }
        public string Flat { get; set; }
        public string FiasXml { get; set; }
        public string FiasStringView { get; set; }
        public Guid? FiasGuid { get; set; }
        public string StreetAddress { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Abonent> AbonentLocationAddresses { get; set; }
        public virtual ICollection<Abonent> AbonentPostalAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Product> ProductAbonentLocationAddresses { get; set; }
        public virtual ICollection<Product> ProductAbonentPostalAddresses { get; set; }
        public virtual ICollection<RegBankRequest> RegBankRequests { get; set; }
        public virtual ICollection<RegRequest> RegRequestLocationAddresses { get; set; }
        public virtual ICollection<RegRequest> RegRequestPostalAddresses { get; set; }
    }
}
