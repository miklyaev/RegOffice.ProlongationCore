using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Состояния заявки на изменение позиции сверки
    /// </summary>
    public partial class AgentBalanceDetailChangeRequestStep
    {

        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }

        /// <summary>
        /// Время смены состояния заявки
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Состояние заявки
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь, сменивший состояние заявки
        /// </summary>
        public int UserId { get; set; }

        public virtual AgentBalanceDetailChangeRequest BalanceDetailChangeRequest { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
