using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица гейтов заявлений
    /// </summary>
    public partial class RegRequestGate
    {
        public int RegRequestGateId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
