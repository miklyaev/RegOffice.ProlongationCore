using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MonitoringMemberView
    {
        public int? ProductId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Ca { get; set; }
        public string Pack { get; set; }
        public DateTime? CertEndTime { get; set; }
        public int? CertId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string StepName { get; set; }
        public string Message { get; set; }
    }
}
