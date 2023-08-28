using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Сведения о ценах и налогах
    /// </summary>
    public partial class Coefficient
    {
        public int CoefficientId { get; set; }

        /// <summary>
        /// Тип коэффициента (цена, налог)
        /// </summary>
        public int? CoefficientTypeId { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Ид номенклатуры
        /// </summary>
        public int? MerchandiseId { get; set; }
    }
}
