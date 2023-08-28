using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица ценовых схем
    /// </summary>
    public partial class PriceScheme
    {

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Тарифная зона
        /// </summary>
        public int TariffZoneId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int? CompetenceCenterId { get; set; }

        /// <summary>
        /// Ведущий партнер
        /// </summary>
        public int? LeadOfficeId { get; set; }

        public virtual Office CompetenceCenter { get; set; }
        public virtual Office LeadOffice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual TariffZone TariffZone { get; set; }
    }
}
