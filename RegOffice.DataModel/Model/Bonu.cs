using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица премий
    /// </summary>
    public partial class Bonu
    {
        public Bonu()
        {
            AgentRewards = new HashSet<AgentReward>();
            Schemes = new HashSet<AgentScheme>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int BonusId { get; set; }

        /// <summary>
        /// Тип премии
        /// </summary>
        public int BonusTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string BonusName { get; set; }

        /// <summary>
        /// Относительная/абсолютная
        /// </summary>
        public bool? Percent { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public decimal? BonusValue { get; set; }

        /// <summary>
        /// Минимальное количество
        /// </summary>
        public int? MinNumber { get; set; }

        /// <summary>
        /// Максимальное количество
        /// </summary>
        public int? MaxNumber { get; set; }

        public virtual BonusType BonusType { get; set; }
        public virtual ICollection<AgentReward> AgentRewards { get; set; }
        public virtual ICollection<AgentScheme> Schemes { get; set; }
    }
}
