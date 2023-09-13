using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContractTariffDiscount
    {
        public int ContractTariffId { get; set; }
        public int DiscountId { get; set; }
        public decimal PercentDiscount { get; set; }
        public decimal DiscountSum { get; set; }
        public int? UserId { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual User User { get; set; }
    }
}
