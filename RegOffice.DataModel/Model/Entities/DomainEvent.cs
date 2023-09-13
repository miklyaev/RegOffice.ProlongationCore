using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DomainEvent
    {
        public Guid Guid { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid EventType { get; set; }
        public string EventBody { get; set; }
        public bool IsPublished { get; set; }
    }
}
