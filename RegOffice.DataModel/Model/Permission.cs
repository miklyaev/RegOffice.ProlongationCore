using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица разрешений для ключа
    /// </summary>
    public partial class Permission
    {
        public Permission()
        {
            KeyPermissions = new HashSet<KeyPermission>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PermissionId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        public virtual PermissionType Type { get; set; }
        public virtual ICollection<KeyPermission> KeyPermissions { get; set; }
    }
}
