using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class StorageType
    {
        public StorageType()
        {
            ProductPeople = new HashSet<ProductPerson>();
            ProductPersonKeys = new HashSet<ProductPersonKey>();
            Products = new HashSet<Product>();
            ReflexRules = new HashSet<ReflexRule>();
            RegRequestMembers = new HashSet<RegRequestMember>();
            RegRequests = new HashSet<RegRequest>();
        }

        public int StorageTypeId { get; set; }
        public string StorageTypeName { get; set; }

        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<ProductPersonKey> ProductPersonKeys { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
