using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LicenseDetail
    {
        public int LicenseId { get; set; }
        public int OfficeId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public int? ItsId { get; set; }
        public bool? IsFree { get; set; }
        public string ItsOptionId { get; set; }
        public string Uin1c { get; set; }

        public virtual Its Its { get; set; }
        public virtual LicensePool License { get; set; }
        public virtual Office Office { get; set; }
    }
}
