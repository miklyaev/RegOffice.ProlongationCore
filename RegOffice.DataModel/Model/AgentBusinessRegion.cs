using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица бизнес регионов
    /// </summary>
    public partial class AgentBusinessRegion
    {
        public AgentBusinessRegion()
        {
            Agents = new HashSet<Agent>();
        }


        /// <summary>
        /// Идентификатор бизнес-региона
        /// </summary>
        public int BusinessRegionId { get; set; }

        /// <summary>
        /// Название бизнес-региона
        /// </summary>
        public string BusinessRegionName { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
