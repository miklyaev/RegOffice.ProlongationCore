using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек гейстов
    /// </summary>
    public partial class GateSetting
    {

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
