using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица истории шагов для таблицы истории ключей
    /// </summary>
    public partial class ProductPersonKeyStep
    {

        /// <summary>
        /// Первичный ключ
        /// </summary>
        public long PersonKeyStepId { get; set; }

        /// <summary>
        /// Идентификатор в таблице истории ключей
        /// </summary>
        public int PersonKeyId { get; set; }

        /// <summary>
        /// Шаг
        /// </summary>
        public int? StepId { get; set; }

        /// <summary>
        /// Время записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual ProductPersonKey PersonKey { get; set; }
        public virtual Step Step { get; set; }
    }
}
