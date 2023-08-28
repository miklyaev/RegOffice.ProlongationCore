using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица партнерских схем
    /// </summary>
    public partial class AgentScheme
    {
        public AgentScheme()
        {
            CaServices = new HashSet<CaService>();
            RewardOptions = new HashSet<RewardOption>();
            Bonus = new HashSet<Bonu>();
            Offices = new HashSet<Office>();
            Plans = new HashSet<Plan>();
        }


        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Дилер
        /// </summary>
        public bool? Dealer { get; set; }

        /// <summary>
        /// Принадлежность
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal? PercentReward { get; set; }

        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }

        /// <summary>
        /// Прайс
        /// </summary>
        public int? PriceId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SchemeId { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int? RegionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual AgentLevel Level { get; set; }
        public virtual Agent Parent { get; set; }
        public virtual Price Price { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Point TransferPoint { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CaService> CaServices { get; set; }
        public virtual ICollection<RewardOption> RewardOptions { get; set; }
        public virtual ICollection<Bonu> Bonus { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
