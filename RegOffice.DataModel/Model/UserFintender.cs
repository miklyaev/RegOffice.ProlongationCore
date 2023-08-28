using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица пользователей финтендера
    /// </summary>
    public partial class UserFintender
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Администратор
        /// </summary>
        public bool IsAdmin { get; set; }

        public virtual User User { get; set; }
    }
}
