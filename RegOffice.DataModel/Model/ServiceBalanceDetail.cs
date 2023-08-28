using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Дополнительные услуги в сверке между партнером и Центром продаж
    /// </summary>
    public partial class ServiceBalanceDetail
    {

        /// <summary>
        /// Идентификатор дополнительной услуги в сверке
        /// </summary>
        public int ServiceBalanceDetailId { get; set; }

        /// <summary>
        /// Позиция в сверке
        /// </summary>
        public int BalanceDetailId { get; set; }

        /// <summary>
        /// Тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Номер услуги
        /// </summary>
        public string ServiceNumber { get; set; }

        public virtual AgentBalanceDetail BalanceDetail { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
