using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int BillId { get; set; }
        public int? AddrId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int StepId { get; set; }
        public decimal SumReward { get; set; }
        public DateTime? DispatchTime { get; set; }
        public int? DispatchUser { get; set; }
        public string Email { get; set; }

        public virtual Addr Addr { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual User DispatchUserNavigation { get; set; }
        public virtual Step Step { get; set; }
    }
}
