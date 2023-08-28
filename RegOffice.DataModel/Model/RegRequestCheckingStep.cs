using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний проверок по заявлениям
    /// </summary>
    public partial class RegRequestCheckingStep
    {

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Проверка
        /// </summary>
        public int CheckingId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RegRequestChecking Checking { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
