using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица вознаграждений за опции
    /// </summary>
    public partial class RewardOption
    {

        /// <summary>
        /// Схема
        /// </summary>
        public int SchemeId { get; set; }

        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal? PercentReward { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual AgentScheme Scheme { get; set; }
    }
}
