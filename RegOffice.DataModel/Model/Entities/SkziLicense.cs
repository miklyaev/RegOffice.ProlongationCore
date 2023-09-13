using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
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
        public int? LicenseTypeId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual SendedBill Bill { get; set; }
        public virtual File LicenseBlank { get; set; }
        public virtual SkziLicenseType LicenseType { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual MerchandiseBill MerchandiseBill { get; set; }
    }
}
