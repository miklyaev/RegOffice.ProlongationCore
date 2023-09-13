using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPotentialMember
    {
        public ProductPotentialMember()
        {
            ProductPotentialMemberProtocols = new HashSet<ProductPotentialMemberProtocol>();
        }

        public int ProductPotentialMemberId { get; set; }
        public int ProductId { get; set; }
        public string Email { get; set; }
        public string Snils { get; set; }
        public bool? IsAdministrator { get; set; }
        public DateTime? NotificationTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<ProductPotentialMemberProtocol> ProductPotentialMemberProtocols { get; set; }
    }
}
