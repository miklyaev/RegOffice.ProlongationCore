using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ролей пользователей
    /// </summary>
    public partial class UserRole
    {

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        public int leId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual Role le { get; set; }
        public virtual User User { get; set; }
    }
}
