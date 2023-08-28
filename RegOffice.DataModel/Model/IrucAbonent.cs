using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица абонентов ИРУЦ
    /// </summary>
    public partial class IrucAbonent
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int IrucAbonentId { get; set; }

        /// <summary>
        /// ГУИД абонента
        /// </summary>
        public Guid AbonentGuid { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public string SystemPrefix { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string EmailLogin { get; set; }

        /// <summary>
        /// Домен СОЭД
        /// </summary>
        public string DomainSoed { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string EmailPassword { get; set; }
    }
}
