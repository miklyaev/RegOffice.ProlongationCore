using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица звонков
    /// </summary>
    public partial class PotentialAbonentCall
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CallId { get; set; }

        /// <summary>
        /// Потенциальный абонент
        /// </summary>
        public int PotentialAbonentId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Время звонка
        /// </summary>
        public DateTime CallTime { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Время следующего звонка
        /// </summary>
        public DateTime? PlannedCallTime { get; set; }

        /// <summary>
        /// Причина состояния
        /// </summary>
        public int? StepReasonId { get; set; }

        public virtual PotentialAbonentCallState Step { get; set; }
        public virtual PotentialAbonentRejectionReason StepReason { get; set; }
        public virtual User User { get; set; }
    }
}
