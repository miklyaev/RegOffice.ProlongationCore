using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Discount
    {
        public Discount()
        {
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            ContractTariffDiscounts = new HashSet<ContractTariffDiscount>();
            OfdDiscounts = new HashSet<OfdDiscount>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }

        public int DiscountId { get; set; }
        public int DiscountTypeId { get; set; }
        public string DiscountName { get; set; }
        public bool? Percent { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public string Article { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? OffTime { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequest> AgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<ContractTariffDiscount> ContractTariffDiscounts { get; set; }
        public virtual ICollection<OfdDiscount> OfdDiscounts { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
