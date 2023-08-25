using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица атрибутов тарифов
    /// </summary>
    public partial class TariffAttribute
    {

        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// Минимальное количество
        /// </summary>
        public int? MinNumber { get; set; }

        /// <summary>
        /// Максимальное количество
        /// </summary>
        public int? MaxNumber { get; set; }

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int? IndexNumber { get; set; }

        /// <summary>
        /// Минимальный порядковый номер
        /// </summary>
        public int? MinIndex { get; set; }

        /// <summary>
        /// Ограничение
        /// </summary>
        public int? LimitId { get; set; }

        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }

        /// <summary>
        /// Ед. времени срока
        /// </summary>
        public int? ValidityUnitId { get; set; }

        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }
        public int TariffAttributeId { get; set; }

        /// <summary>
        /// Максимальный порядковый номер
        /// </summary>
        public int? MaxIndex { get; set; }
    }
}
