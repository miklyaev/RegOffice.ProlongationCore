using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ReportFullTimeConnectCert
    {
        public int? CertificateId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? InitialTime { get; set; }
        public bool? IsFullTime { get; set; }
        public int? AgentId { get; set; }
    }
}
