using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица задач по построению сверок
    /// </summary>
    public partial class BalanceBuildTask
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int BalanceBuildTaskId { get; set; }

        /// <summary>
        /// Тип сверки
        /// </summary>
        public int AgentBalanceGroupId { get; set; }

        /// <summary>
        /// Год сверки
        /// </summary>
        public int BalanceYear { get; set; }

        /// <summary>
        /// Месяц сверки
        /// </summary>
        public int BalanceMonth { get; set; }

        /// <summary>
        /// Время создания задачи
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Время начала выполнения задачи
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Время окончания выполнения задачи
        /// </summary>
        public DateTime? FinishTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Пользователь, создавший задачу
        /// </summary>
        public int UserId { get; set; }

        public virtual AgentBalanceGroup AgentBalanceGroup { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
