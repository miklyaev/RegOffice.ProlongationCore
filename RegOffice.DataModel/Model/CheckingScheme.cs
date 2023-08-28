using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица схемы проверок
    /// </summary>
    public partial class CheckingScheme
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SchemeId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Тип проверки
        /// </summary>
        public int CheckingTypeId { get; set; }

        /// <summary>
        /// Режим проверки
        /// </summary>
        public int CheckingModeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual CheckingMode CheckingMode { get; set; }
        public virtual CheckingType CheckingType { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
