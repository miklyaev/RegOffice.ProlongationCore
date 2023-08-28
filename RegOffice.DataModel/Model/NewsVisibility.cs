using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица видимости для новостей
    /// </summary>
    public partial class NewsVisibility
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int NewsVisibilityId { get; set; }

        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int? AgentId { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        public int? leId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        /// <summary>
        /// Уровень агента
        /// </summary>
        public int? AgentLevelId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual AgentLevel AgentLevel { get; set; }
        public virtual News News { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Role le { get; set; }
    }
}
