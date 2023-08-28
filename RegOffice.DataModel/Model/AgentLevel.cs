using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица уровней партнеров
    /// </summary>
    public partial class AgentLevel
    {
        public AgentLevel()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            Agents = new HashSet<Agent>();
            NewsVisibilities = new HashSet<NewsVisibility>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string LevelName { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string LevelNote { get; set; }

        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
    }
}
