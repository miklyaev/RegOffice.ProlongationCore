using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model2
{
    /// <summary>
    /// Таблица услуг продукта
    /// </summary>
    public partial class ProductTariff
    {

        /// <summary>
        /// Услуга по договору
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
    }
}
