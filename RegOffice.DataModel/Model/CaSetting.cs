using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица настроек УЦ
    /// </summary>
    public partial class CaSetting
    {

        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaSettingId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
