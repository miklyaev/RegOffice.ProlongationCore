using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица правил отражений
    /// </summary>
    public partial class ReflexRule
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ReflexRuleId { get; set; }

        /// <summary>
        /// Отражение
        /// </summary>
        public int ReflexId { get; set; }

        /// <summary>
        /// Тип отражения
        /// </summary>
        public int ReflexTypeId { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        /// <summary>
        /// Курьер
        /// </summary>
        public int? MessengerId { get; set; }

        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual Messenger Messenger { get; set; }
        public virtual Office Office { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Reflex Reflex { get; set; }
        public virtual ReflexType ReflexType { get; set; }
        public virtual StorageType StorageType { get; set; }
    }
}
