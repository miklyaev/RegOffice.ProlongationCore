using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ответов
    /// </summary>
    public partial class InterviewAnswer
    {
        public InterviewAnswer()
        {
            Agents = new HashSet<Agent>();
            Users = new HashSet<User>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AnswerId { get; set; }

        /// <summary>
        /// Опрос
        /// </summary>
        public int InterviewId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public string AnswerValue { get; set; }

        public virtual Interview Interview { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
