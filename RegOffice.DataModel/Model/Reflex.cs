using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица отражений БД на серверах
    /// </summary>
    public partial class Reflex
    {
        public Reflex()
        {
            ReflexMessengers = new HashSet<ReflexMessenger>();
            ReflexProductTypes = new HashSet<ReflexProductType>();
            ReflexProducts = new HashSet<ReflexProduct>();
            ReflexRules = new HashSet<ReflexRule>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ReflexId { get; set; }

        /// <summary>
        /// Имя БД
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Порт
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Тестовое
        /// </summary>
        public bool? IsTest { get; set; }

        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual ICollection<ReflexMessenger> ReflexMessengers { get; set; }
        public virtual ICollection<ReflexProductType> ReflexProductTypes { get; set; }
        public virtual ICollection<ReflexProduct> ReflexProducts { get; set; }
        public virtual ICollection<ReflexRule> ReflexRules { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
    }
}
