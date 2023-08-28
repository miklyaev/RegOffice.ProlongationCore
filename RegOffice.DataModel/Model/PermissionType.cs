using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов разрешений
    /// </summary>
    public partial class PermissionType
    {
        public PermissionType()
        {
            Permissions = new HashSet<Permission>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PermissionTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PermissionTypeName { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
