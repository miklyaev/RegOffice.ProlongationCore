using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица учетных записей заявления
    /// </summary>
    public partial class RegRequestAccount
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Тип учетной записи
        /// </summary>
        public int PortalTypeId { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        public virtual PortalType PortalType { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
