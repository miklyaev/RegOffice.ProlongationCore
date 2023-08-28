using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица вознаграждений партнеров
    /// </summary>
    public partial class AgentReward
    {

        /// <summary>
        /// Тариф по договору
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }

        /// <summary>
        /// Сумма вознаграждения
        /// </summary>
        public decimal SumReward { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RewardId { get; set; }

        /// <summary>
        /// Премия
        /// </summary>
        public int? BonusId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Bonu Bonus { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
    }
}
