using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица групп ролей
    /// </summary>
    public partial class RoleGroup
    {
        public RoleGroup()
        {
            Roles = new HashSet<Role>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int leGroupId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string leGroupName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
