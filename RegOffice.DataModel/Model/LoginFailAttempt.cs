using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class LoginFailAttempt
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FailAttemptId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Время попытки логина
        /// </summary>
        public DateTime AttemptDate { get; set; }
    }
}
