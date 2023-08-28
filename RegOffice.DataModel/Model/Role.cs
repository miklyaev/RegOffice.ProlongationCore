using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ролей пользователей
    /// </summary>
    public partial class Role
    {
        public Role()
        {
            NewsVisibilities = new HashSet<NewsVisibility>();
            RoleModules = new HashSet<RoleModule>();
            UserRoles = new HashSet<UserRole>();
            Users = new HashSet<User>();
            AvailableRoles = new HashSet<Role>();
            les = new HashSet<Role>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int leId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string leName { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        public int leGroupId { get; set; }

        /// <summary>
        /// Публичное наименование роли
        /// </summary>
        public string lePublicName { get; set; }

        public virtual RoleGroup leGroup { get; set; }
        public virtual ICollection<NewsVisibility> NewsVisibilities { get; set; }
        public virtual ICollection<RoleModule> RoleModules { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Role> AvailableRoles { get; set; }
        public virtual ICollection<Role> les { get; set; }
    }
}
