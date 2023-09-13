using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CallbackRequestType
    {
        public CallbackRequestType()
        {
            CallbackRequests = new HashSet<CallbackRequest>();
        }

        public int CallbackRequestTypeId { get; set; }
        public string CallbackRequestTypeName { get; set; }

        public virtual ICollection<CallbackRequest> CallbackRequests { get; set; }
    }
}
