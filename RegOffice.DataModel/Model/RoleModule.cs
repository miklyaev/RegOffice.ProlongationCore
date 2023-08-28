using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи ролей с модулями
    /// </summary>
    public partial class RoleModule
    {

        /// <summary>
        /// Роль
        /// </summary>
        public int leId { get; set; }

        /// <summary>
        /// Модуль
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Уровень доступа
        /// </summary>
        public int AccessLevelId { get; set; }

        public virtual AccessLevel AccessLevel { get; set; }
        public virtual Module Module { get; set; }
        public virtual Role le { get; set; }
    }
}
