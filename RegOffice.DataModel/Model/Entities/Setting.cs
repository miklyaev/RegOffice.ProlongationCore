using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Setting
    {
        public Setting()
        {
            AgentSettings = new HashSet<AgentSetting>();
            ApplicationSettings = new HashSet<ApplicationSetting>();
            CaSettings = new HashSet<CaSetting>();
            CertificateServiceSettings = new HashSet<CertificateServiceSetting>();
            GateSettings = new HashSet<GateSetting>();
            NewsSettings = new HashSet<NewsSetting>();
            OfdPinSettings = new HashSet<OfdPinSetting>();
            OfficeSettings = new HashSet<OfficeSetting>();
            UserSettings = new HashSet<UserSetting>();
        }

        public int SettingId { get; set; }
        public string SettingName { get; set; }
        public int ValueTypeId { get; set; }

        public virtual ValueType ValueType { get; set; }
        public virtual ICollection<AgentSetting> AgentSettings { get; set; }
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual ICollection<CaSetting> CaSettings { get; set; }
        public virtual ICollection<CertificateServiceSetting> CertificateServiceSettings { get; set; }
        public virtual ICollection<GateSetting> GateSettings { get; set; }
        public virtual ICollection<NewsSetting> NewsSettings { get; set; }
        public virtual ICollection<OfdPinSetting> OfdPinSettings { get; set; }
        public virtual ICollection<OfficeSetting> OfficeSettings { get; set; }
        public virtual ICollection<UserSetting> UserSettings { get; set; }
    }
}
