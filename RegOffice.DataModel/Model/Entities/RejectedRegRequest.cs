using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RejectedRegRequest
    {
        public int RejectedRegRequestId { get; set; }
        public int? RegRequestTypeId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ShortName { get; set; }
        public DateTime CreationTime { get; set; }
        public string Message { get; set; }
        public int StepId { get; set; }
        public string Note { get; set; }
        public int WorkflowId { get; set; }
        public int? ProductTypeId { get; set; }
        public Guid? ProductGuid { get; set; }
        public int? RequestId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual RegRequestType RegRequestType { get; set; }
        public virtual Step Step { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
