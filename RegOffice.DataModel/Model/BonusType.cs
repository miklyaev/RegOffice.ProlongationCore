using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов премий
    /// </summary>
    public partial class BonusType
    {
        public BonusType()
        {
            Bonus = new HashSet<Bonu>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int BonusTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string BonusTypeName { get; set; }

        public virtual ICollection<Bonu> Bonus { get; set; }
    }
}
