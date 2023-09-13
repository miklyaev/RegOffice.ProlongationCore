using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProxyAgent
    {
        public ProxyAgent()
        {
            Products = new HashSet<Product>();
            RegRequests = new HashSet<RegRequest>();
        }

        public int ProxyAgentId { get; set; }
        public string ProxyAgentName { get; set; }
        public int AbonentId { get; set; }
        public int? ProductId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Office Office { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequests { get; set; }
    }
}
