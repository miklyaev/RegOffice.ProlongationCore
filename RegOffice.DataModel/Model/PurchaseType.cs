using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов закупок
    /// </summary>
    public partial class PurchaseType
    {
        public PurchaseType()
        {
            PotentialAbonentRts = new HashSet<PotentialAbonentRt>();
        }


        /// <summary>
        /// Идентификатор типа закупки
        /// </summary>
        public int PurchaseTypeId { get; set; }

        /// <summary>
        /// Наименование типа закупки
        /// </summary>
        public string PurchaseTypeName { get; set; }

        public virtual ICollection<PotentialAbonentRt> PotentialAbonentRts { get; set; }
    }
}
