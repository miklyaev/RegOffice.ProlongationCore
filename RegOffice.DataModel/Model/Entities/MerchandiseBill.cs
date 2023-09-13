using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MerchandiseBill
    {
        public MerchandiseBill()
        {
            SkziLicenses = new HashSet<SkziLicense>();
        }

        public int MerchandiseBillId { get; set; }
        public int? BillId { get; set; }
        public int? Count { get; set; }
        public int? MerchandiseId { get; set; }
        public decimal TotalSum { get; set; }
        public decimal? SumReward { get; set; }
        public decimal? Price { get; set; }
        public decimal? ScSumReward { get; set; }
        public decimal? ScPrice { get; set; }

        public virtual SendedBill Bill { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
