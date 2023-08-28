using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Контактные данные
    /// </summary>
    public partial class Contact
    {
        public Contact()
        {
            ContactUses = new HashSet<ContactUse>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<ContactUse> ContactUses { get; set; }
    }
}
