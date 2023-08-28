using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек агентов
    /// </summary>
    public partial class AgentSetting
    {

        /// <summary>
        /// Агент
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual User User { get; set; }
    }
}
