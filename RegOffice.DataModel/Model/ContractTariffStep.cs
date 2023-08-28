using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний услуг по договорам
    /// </summary>
    public partial class ContractTariffStep
    {

        /// <summary>
        /// Услуга по договору
        /// </summary>
        public int ContractTariffId { get; set; }

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

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
