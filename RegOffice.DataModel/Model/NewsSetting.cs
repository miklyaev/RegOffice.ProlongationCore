using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек новости
    /// </summary>
    public partial class NewsSetting
    {

        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        public virtual News News { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
