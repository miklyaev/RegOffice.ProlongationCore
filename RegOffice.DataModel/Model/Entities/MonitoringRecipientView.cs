using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MonitoringRecipientView
    {
        public int? ProductId { get; set; }
        public int? ProtocolId { get; set; }
        public string ProtocolName { get; set; }
        public string Code { get; set; }
        public string Sos { get; set; }
        public string Server { get; set; }
        public string Pack { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public string Message { get; set; }
    }
}
