using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица уровней доступа
    /// </summary>
    public partial class AccessLevel
    {
        public AccessLevel()
        {
            RoleModules = new HashSet<RoleModule>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int AccessLevelId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string AccessLevelName { get; set; }

        /// <summary>
        /// Приоритет операции
        /// </summary>
        public int? LevelPriority { get; set; }

        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
