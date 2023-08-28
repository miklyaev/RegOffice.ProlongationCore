using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица проверки данных паспорта для продуктов
    /// </summary>
    public partial class ProductPassportChecking
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PassportCheckingId { get; set; }

        /// <summary>
        /// Проверка скана паспорта
        /// </summary>
        public int ProductCheckingId { get; set; }

        /// <summary>
        /// Тип данных паспорта
        /// </summary>
        public int PassportDataTypeId { get; set; }

        /// <summary>
        /// Данные паспорта со скана
        /// </summary>
        public string PassportDataFromScan { get; set; }

        /// <summary>
        /// Данные паспорта из продукта
        /// </summary>
        public string PassportDataFromProduct { get; set; }

        /// <summary>
        /// Данные совпадают
        /// </summary>
        public bool IsEquals { get; set; }

        public virtual PassportDataType PassportDataType { get; set; }
        public virtual ProductChecking ProductChecking { get; set; }
    }
}
