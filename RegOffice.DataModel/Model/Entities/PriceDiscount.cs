using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceDiscount
    {
        public PriceDiscount()
        {
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
        }

        public int PriceId { get; set; }
        public int DiscountId { get; set; }
        public string RegisteredName { get; set; }
        public DateTime InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int StepId { get; set; }
        public int? UserId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Price Price { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
    }
}
