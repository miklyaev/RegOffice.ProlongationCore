using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Ao5BillView
    {
        public int? BillId { get; set; }
        public string BillNumber { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? BillTotalSum { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceNdsNumber { get; set; }
        public DateTime? CancelTime { get; set; }
        public int? AgentId { get; set; }
    }
}
