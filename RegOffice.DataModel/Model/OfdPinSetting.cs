using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class OfdPinSetting
    {

        /// <summary>
        /// Пин ид.
        /// </summary>
        public int PinId { get; set; }

        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; }

        public virtual OfdPin Pin { get; set; }
        public virtual Setting Setting { get; set; }
    }
}
