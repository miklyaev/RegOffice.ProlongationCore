using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица опросов
    /// </summary>
    public partial class Interview
    {
        public Interview()
        {
            InterviewAnswers = new HashSet<InterviewAnswer>();
            InterviewSteps = new HashSet<InterviewStep>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int InterviewId { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Множественный выбор
        /// </summary>
        public bool MultySelect { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<InterviewAnswer> InterviewAnswers { get; set; }
        public virtual ICollection<InterviewStep> InterviewSteps { get; set; }
    }
}
