﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AbonnentClosedConnectCert
    {
        public DateTime? EndTime { get; set; }
        public int? CertificateId { get; set; }
        public int? ProductId { get; set; }
        public int? AbonentId { get; set; }
        public int? AgentId { get; set; }
        public DateTime? ConnectionDate { get; set; }
    }
}
