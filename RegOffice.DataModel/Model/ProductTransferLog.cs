using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица логирования переноса продуктов
    /// </summary>
    public partial class ProductTransferLog
    {
        public ProductTransferLog()
        {
            TransferTariffLogs = new HashSet<TransferTariffLog>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductTransferId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Предыдущий офис
        /// </summary>
        public int PreviousOfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Office PreviousOffice { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogs { get; set; }
    }
}
