using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CallbackRequest
    {
        public int RequestId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string DiagReportId { get; set; }
        public int? CalloutId { get; set; }
        public int CallbackRequestTypeId { get; set; }

        public virtual CallbackRequestType CallbackRequestType { get; set; }
    }
}
