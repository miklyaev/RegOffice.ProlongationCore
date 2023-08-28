using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица разрешенных УЦ для типа программы
    /// </summary>
    public partial class CaProductType
    {

        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }

        /// <summary>
        /// Тип программы
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Дата отключения УЦ для типа продукта
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Является УЦ по умолчанию для типа продукта
        /// </summary>
        public bool IsDefault { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
