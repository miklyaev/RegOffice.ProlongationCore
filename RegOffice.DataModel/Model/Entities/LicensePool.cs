using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LicensePool
    {
        public LicensePool()
        {
            ContractLicenses = new HashSet<ContractLicense>();
            LicensePoolSteps = new HashSet<LicensePoolStep>();
        }

        public int LicenseId { get; set; }
        public int LicenseTypeId { get; set; }
        public string RegistrationNumber { get; set; }
        public string PinCode { get; set; }
        public int StepId { get; set; }

        public virtual LicenseType LicenseType { get; set; }
        public virtual Step Step { get; set; }
        public virtual LicenseDetail LicenseDetail { get; set; }
        public virtual ICollection<ContractLicense> ContractLicenses { get; set; }
        public virtual ICollection<LicensePoolStep> LicensePoolSteps { get; set; }
    }
}
