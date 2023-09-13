using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            RegRequests = new HashSet<RegRequest>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
