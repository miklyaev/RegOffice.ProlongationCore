using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи ключ - серийный номер носителя
    /// </summary>
    public partial class KeySerialNumber
    {

        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Серийный номер носителя
        /// </summary>
        public string SerialNumber { get; set; }

        public virtual Key Key { get; set; }
    }
}
