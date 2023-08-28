using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний сотрудников продуктов
    /// </summary>
    public partial class ProductPersonStep
    {

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual ProductPerson ProductPerson { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
