using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек офисов
    /// </summary>
    public partial class OfficeSetting
    {

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }

        public virtual Office Office { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
