using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица периодов времени уведомлений для абонентов
    /// </summary>
    public partial class ProductNotice
    {

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Смещение времени
        /// </summary>
        public TimeSpan TimeOffset { get; set; }

        /// <summary>
        /// Время начала уведомлений
        /// </summary>
        public TimeOnly BeginTime { get; set; }

        /// <summary>
        /// Время завершения уведомлений
        /// </summary>
        public TimeOnly EndTime { get; set; }

        public virtual Product Product { get; set; }
    }
}
