using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица сверок в обработке
    /// </summary>
    public partial class AgentBalanceProcessing
    {

        /// <summary>
        /// Сверка
        /// </summary>
        public int AgentBalanceGroupId { get; set; }

        /// <summary>
        /// Время блокировки
        /// </summary>
        public DateTime BlockTime { get; set; }

        public virtual AgentBalanceGroup AgentBalanceGroup { get; set; }
    }
}
