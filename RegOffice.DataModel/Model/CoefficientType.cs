using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Типы цен и налогов
    /// </summary>
    public partial class CoefficientType
    {

        /// <summary>
        /// Тип коэффициента
        /// </summary>
        public int CoefficientTypeId { get; set; }

        /// <summary>
        /// Имя типа
        /// </summary>
        public string CoefficientTypeName { get; set; }
    }
}
