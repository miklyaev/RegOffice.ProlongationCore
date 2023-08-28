using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class UserPassword
    {

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual User User { get; set; }
    }
}
