using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов токенов
    /// </summary>
    public partial class TokenType
    {
        public TokenType()
        {
            Tokens = new HashSet<Token>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int TokenTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string TokenTypeName { get; set; }

        /// <summary>
        /// Время жизни в секундах
        /// </summary>
        public int LifeTime { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }
    }
}
