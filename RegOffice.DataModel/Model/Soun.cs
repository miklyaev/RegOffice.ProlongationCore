using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица СОУН
    /// </summary>
    public partial class Soun
    {
        public Soun()
        {
            InverseParentTaxNavigation = new HashSet<Soun>();
        }


        /// <summary>
        /// Код инспекции
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Код предыдущей инспекции
        /// </summary>
        public string ParentTax { get; set; }

        /// <summary>
        /// Наименование инспекции
        /// </summary>
        public string TaxName { get; set; }

        public virtual Soun ParentTaxNavigation { get; set; }
        public virtual ICollection<Soun> InverseParentTaxNavigation { get; set; }
    }
}
