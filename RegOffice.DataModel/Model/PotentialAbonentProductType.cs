using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов продуктов
    /// </summary>
    public partial class PotentialAbonentProductType
    {
        public PotentialAbonentProductType()
        {
            PotentialAbonentStepTypes = new HashSet<PotentialAbonentStepType>();
        }


        /// <summary>
        /// ID типа продукта
        /// </summary>
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Наименование типа продукта
        /// </summary>
        public string ProductTypeName { get; set; }

        public virtual ICollection<PotentialAbonentStepType> PotentialAbonentStepTypes { get; set; }
    }
}
