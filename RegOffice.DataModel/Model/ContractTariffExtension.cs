using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица расширений услуг продукта
    /// </summary>
    public partial class ContractTariffExtension
    {

        /// <summary>
        /// Расширение
        /// </summary>
        public int ExtensionId { get; set; }

        /// <summary>
        /// Главная услуга
        /// </summary>
        public int ContractTariffId { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual ContractTariff Extension { get; set; }
    }
}
