using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица логирования переноса лицензий
    /// </summary>
    public partial class TransferTariffLog
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransferTariffId { get; set; }

        /// <summary>
        /// Лог переноса продукта
        /// </summary>
        public int ProductTransferId { get; set; }

        /// <summary>
        /// Лицензия
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Предыдущая лицензия
        /// </summary>
        public int PreviousContractTariffId { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual ContractTariff PreviousContractTariff { get; set; }
        public virtual ProductTransferLog ProductTransfer { get; set; }
    }
}
