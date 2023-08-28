using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний регистраций запросов на получение банковской гарантии
    /// </summary>
    public partial class RegBankRequestStep
    {

        /// <summary>
        /// Запрос
        /// </summary>
        public int RegBankRequestId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        public virtual RegBankRequest RegBankRequest { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
