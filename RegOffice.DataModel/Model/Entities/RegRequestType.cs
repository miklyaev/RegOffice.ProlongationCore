using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestType
    {
        public RegRequestType()
        {
            RegRequests = new HashSet<RegRequest>();
            RejectedRegRequests = new HashSet<RejectedRegRequest>();
        }

        public int RegRequestTypeId { get; set; }
        public string RegRequestTypeName { get; set; }

        public virtual ICollection<RegRequest> RegRequests { get; set; }
        public virtual ICollection<RejectedRegRequest> RejectedRegRequests { get; set; }
    }
}
