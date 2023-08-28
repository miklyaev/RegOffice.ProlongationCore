using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов данных паспорта
    /// </summary>
    public partial class PassportDataType
    {
        public PassportDataType()
        {
            ProductPassportCheckings = new HashSet<ProductPassportChecking>();
            RegRequestPassportCheckings = new HashSet<RegRequestPassportChecking>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int PassportDataTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PassportDataTypeName { get; set; }

        public virtual ICollection<ProductPassportChecking> ProductPassportCheckings { get; set; }
        public virtual ICollection<RegRequestPassportChecking> RegRequestPassportCheckings { get; set; }
    }
}
