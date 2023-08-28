using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов проверок
    /// </summary>
    public partial class CheckingType
    {
        public CheckingType()
        {
            CheckingSchemes = new HashSet<CheckingScheme>();
            ProductCheckings = new HashSet<ProductChecking>();
            RegRequestCheckings = new HashSet<RegRequestChecking>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int CheckingTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string CheckingTypeName { get; set; }

        public virtual ICollection<CheckingScheme> CheckingSchemes { get; set; }
        public virtual ICollection<ProductChecking> ProductCheckings { get; set; }
        public virtual ICollection<RegRequestChecking> RegRequestCheckings { get; set; }
    }
}
