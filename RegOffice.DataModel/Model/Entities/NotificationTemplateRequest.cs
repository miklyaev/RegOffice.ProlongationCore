using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class NotificationTemplateRequest
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int TypeId { get; set; }
        public DateTime? CreationTime { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime? EndTime { get; set; }
        public string Query { get; set; }
        public int? Trigger { get; set; }
        public int FileId { get; set; }

        public virtual Product Product { get; set; }
        public virtual NotificationTemplateRequestType Type { get; set; }
    }
}
