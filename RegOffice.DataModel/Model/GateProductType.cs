using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица систем обновлений
    /// </summary>
    public partial class GateProductType
    {

        /// <summary>
        /// ИД записи
        /// </summary>
        public int GateProductTypeId { get; set; }

        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
