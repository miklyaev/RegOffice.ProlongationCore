using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Контактные данные заявления
    /// </summary>
    public partial class RegRequestContact
    {
        public RegRequestContact()
        {
            RegRequestContactUses = new HashSet<RegRequestContactUse>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<RegRequestContactUse> RegRequestContactUses { get; set; }
    }
}
