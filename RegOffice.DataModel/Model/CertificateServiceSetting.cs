using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CertificateServiceSetting
    {

        /// <summary>
        /// Ид. сервиса
        /// </summary>
        public int CertificateServiceId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение настройки
        /// </summary>
        public string Value { get; set; }

        public virtual CertificateService CertificateService { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
