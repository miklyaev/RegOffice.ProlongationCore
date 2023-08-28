using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица токенов обновления
    /// </summary>
    public partial class RefreshToken
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RefreshTokenId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Токен
        /// </summary>
        public string RefreshTokenProp { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Срок действия токена
        /// </summary>
        public DateTime ExpiresIn { get; set; }

        /// <summary>
        /// Дата блокировки
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual User User { get; set; }
    }
}
