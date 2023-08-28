using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек
    /// </summary>
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


        /// <summary>
        /// Код
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// Тип значения
        /// </summary>
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
