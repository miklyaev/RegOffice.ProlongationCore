using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Контактные данные сотрудников
    /// </summary>
    public partial class ContactPerson
    {
        public ContactPerson()
        {
            ContactPersonUses = new HashSet<ContactPersonUse>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactPersonId { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }

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

        public virtual ProductPerson ProductPerson { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<ContactPersonUse> ContactPersonUses { get; set; }
    }
}
