using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Связь счетов и номенклатур
    /// </summary>
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

        /// <summary>
        /// Вознаграждение
        /// </summary>
        public decimal? SumReward { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// Вознаграждение ЦП
        /// </summary>
        public decimal? ScSumReward { get; set; }

        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal? ScPrice { get; set; }

        public virtual SendedBill Bill { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
