using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ServiceBalanceDetail
    {
        public int ServiceBalanceDetailId { get; set; }
        public int BalanceDetailId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceNumber { get; set; }

        public virtual AgentBalanceDetail BalanceDetail { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
