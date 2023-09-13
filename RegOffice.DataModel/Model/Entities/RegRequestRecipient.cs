using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestRecipient
    {
        public RegRequestRecipient()
        {
            RegRequestRoutes = new HashSet<RegRequestRoute>();
        }

        public int RecipientId { get; set; }
        public int RegRequestId { get; set; }
        public int ProtocolId { get; set; }
        public string RecipientCode { get; set; }
        public int? Index { get; set; }

        public virtual Protocol Protocol { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual ICollection<RegRequestRoute> RegRequestRoutes { get; set; }
    }
}
