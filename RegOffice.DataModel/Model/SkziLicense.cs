using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class SkziLicense
    {
        public int LicenseId { get; set; }
        public string LicenseNumber { get; set; }
        public int? AgentId { get; set; }
        public int? BillId { get; set; }
        public int? MerchandiseId { get; set; }
        public int? MerchandiseBillId { get; set; }
        public int? LicenseBlankId { get; set; }

        /// <summary>
        /// Тип лицензии
        /// </summary>
        public int? LicenseTypeId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual File LicenseBlank { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual MerchandiseBill MerchandiseBill { get; set; }
    }
}
