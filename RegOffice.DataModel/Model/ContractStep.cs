using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний договоров
    /// </summary>
    public partial class ContractStep
    {

        /// <summary>
        /// Договор
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
