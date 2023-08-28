using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Тип контактных данных
    /// </summary>
    public partial class ContactType
    {
        public ContactType()
        {
            ContactPeople = new HashSet<ContactPerson>();
            Contacts = new HashSet<Contact>();
            DssUsers = new HashSet<DssUser>();
            RegRequestContacts = new HashSet<RegRequestContact>();
            RegRequestMemberContacts = new HashSet<RegRequestMemberContact>();
        }


        /// <summary>
        /// Код
        /// </summary>
        public int ContactTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string ContactTypeName { get; set; }

        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestContact> RegRequestContacts { get; set; }
        public virtual ICollection<RegRequestMemberContact> RegRequestMemberContacts { get; set; }
    }
}
