using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица токенов
    /// </summary>
    public partial class Token
    {
        public Token()
        {
            Gates = new HashSet<Gate>();
        }


        /// <summary>
        /// Приложение
        /// </summary>
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TokenTypeId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid TokenId { get; set; }

        /// <summary>
        /// Время жизни в секундах
        /// </summary>
        public int LifeTime { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }

        public virtual Application Application { get; set; }
        public virtual Product Product { get; set; }
        public virtual TokenType TokenType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
    }
}
