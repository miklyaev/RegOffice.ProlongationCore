using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица данных по личному кабинету
    /// </summary>
    public partial class PortalAccount
    {

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Тип личного кабинета
        /// </summary>
        public int PortalTypeId { get; set; }

        /// <summary>
        /// Идентификатор записи на портале
        /// </summary>
        public string AccountId { get; set; }

        public virtual PortalType PortalType { get; set; }
        public virtual Product Product { get; set; }
    }
}
