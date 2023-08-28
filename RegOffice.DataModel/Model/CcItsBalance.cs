using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CcItsBalance
    {

        /// <summary>
        /// ЦК
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Месяц
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// % вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int BalanceId { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
