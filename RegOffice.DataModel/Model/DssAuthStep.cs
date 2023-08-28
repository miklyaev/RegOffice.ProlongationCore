using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица истории состояний аутентификации пользователей DSS
    /// </summary>
    public partial class DssAuthStep
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Запись аутентификации
        /// </summary>
        public int AuthId { get; set; }

        /// <summary>
        /// Шаг аутентификации
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Время шага
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Срок действия ключа
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Время проверки
        /// </summary>
        public DateTime? CheckTime { get; set; }

        public virtual DssAuth Auth { get; set; }
        public virtual Step Step { get; set; }
    }
}
