using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний опросов
    /// </summary>
    public partial class InterviewStep
    {

        /// <summary>
        /// Опрос
        /// </summary>
        public int InterviewId { get; set; }

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

        public virtual Interview Interview { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
