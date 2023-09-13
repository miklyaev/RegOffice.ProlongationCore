using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
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

        public int ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }

        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<DssUser> DssUsers { get; set; }
        public virtual ICollection<RegRequestContact> RegRequestContacts { get; set; }
        public virtual ICollection<RegRequestMemberContact> RegRequestMemberContacts { get; set; }
    }
}
