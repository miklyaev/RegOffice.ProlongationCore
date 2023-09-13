using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContractLicense
    {
        public int ContractId { get; set; }
        public int LicenseId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual LicensePool License { get; set; }
    }
}
