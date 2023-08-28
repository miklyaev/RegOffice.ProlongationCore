using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица продуктов в обработке
    /// </summary>
    public partial class ProcessingProduct
    {

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Время блокировки
        /// </summary>
        public DateTime BlockTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Режим
        /// </summary>
        public int ModeId { get; set; }

        public virtual Application Application { get; set; }
        public virtual ProcessingMode Mode { get; set; }
        public virtual User User { get; set; }
    }
}
