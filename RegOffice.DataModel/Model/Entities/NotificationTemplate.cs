using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class NotificationTemplate
    {
        public Guid Guid { get; set; }
        public int ProductId { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime EndTime { get; set; }
        public string Query { get; set; }
        public int Trigger { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? TriggerTime { get; set; }
        public int? FileId { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual NotificationTemplateState State { get; set; }
    }
}
