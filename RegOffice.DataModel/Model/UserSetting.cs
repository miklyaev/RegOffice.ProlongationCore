using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек пользователей
    /// </summary>
    public partial class UserSetting
    {

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        public virtual Setting Setting { get; set; }
        public virtual User User { get; set; }
    }
}
