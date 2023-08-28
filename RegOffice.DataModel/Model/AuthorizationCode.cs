using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица кодов авторизации
    /// </summary>
    public partial class AuthorizationCode
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int IdAuthorizationCode { get; set; }

        /// <summary>
        /// Идентификатор авторизации
        /// </summary>
        public Guid AuthorizationId { get; set; }

        /// <summary>
        /// Счетчик авторизации
        /// </summary>
        public int? AuthorizationCount { get; set; }

        /// <summary>
        /// Секретный ключ
        /// </summary>
        public Guid AuthorizationSecretKey { get; set; }
    }
}
