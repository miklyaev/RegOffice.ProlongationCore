using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек приложений
    /// </summary>
    public partial class ApplicationSetting
    {

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        public virtual Application Application { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
