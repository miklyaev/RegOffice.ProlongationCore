using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateServiceSetting
    {
        public int CertificateServiceId { get; set; }
        public int SettingId { get; set; }
        public string Value { get; set; }

        public virtual CertificateService CertificateService { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
