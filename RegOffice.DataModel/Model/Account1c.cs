using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица учетных записей ЛК 1С
    /// </summary>
    public partial class Account1c
    {

        /// <summary>
        /// Идиентификатор
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Идентификационный номер пользователя 1С
        /// </summary>
        public string Uin { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string Email { get; set; }
    }
}
