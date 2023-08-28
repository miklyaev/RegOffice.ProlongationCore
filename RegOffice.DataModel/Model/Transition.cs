using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица переходов
    /// </summary>
    public partial class Transition
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransitionId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int NextStepId { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Тип объекта
        /// </summary>
        public int ObjectTypeId { get; set; }

        /// <summary>
        /// Объект
        /// </summary>
        public int? ObjectId { get; set; }

        /// <summary>
        /// Условие
        /// </summary>
        public int ConditionId { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public int? Priority { get; set; }

        public virtual Application Application { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Step NextStep { get; set; }
        public virtual Object Object { get; set; }
        public virtual ObjectType ObjectType { get; set; }
        public virtual Step Step { get; set; }
    }
}
