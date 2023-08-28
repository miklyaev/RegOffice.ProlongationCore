using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица протоколов гейтов
    /// </summary>
    public partial class GateProtocol
    {

        /// <summary>
        /// ИД записи
        /// </summary>
        public int GateProtocolId { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Protocol Protocol { get; set; }
    }
}
