using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица логов изменений статусов гейтов продуктов
    /// </summary>
    public partial class ProductNetNodeStep
    {

        /// <summary>
        /// ИД записи
        /// </summary>
        public int ProductNetNodeStepId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Время смены шага
        /// </summary>
        public DateTime? LogTime { get; set; }

        public virtual ProductNetNode ProductNetNode { get; set; }
        public virtual Step Step { get; set; }
    }
}
