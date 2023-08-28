using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Ежемесячные сверки между партнером и офисами БИТ
    /// </summary>
    public partial class AgentBalanceOffice
    {

        /// <summary>
        /// Идентификатор сверки по офисам
        /// </summary>
        public int BalanceOfficeId { get; set; }

        /// <summary>
        /// Баланс
        /// </summary>
        public int BalanceId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Дата одобрения сверки офисом
        /// </summary>
        public DateTime? OfficeAcceptDate { get; set; }

        public virtual AgentBalance Balance { get; set; }
        public virtual Office Office { get; set; }
    }
}
