using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MonitoringAbonentView
    {
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Partner { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? StepId { get; set; }
        public string Message { get; set; }
        public Guid? ProductGuid { get; set; }
        public DateTime? RequestCreationTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public string Note { get; set; }
        public string Ruid { get; set; }
    }
}
