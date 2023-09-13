using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContactPerson
    {
        public ContactPerson()
        {
            ContactPersonUses = new HashSet<ContactPersonUse>();
        }

        public int ContactPersonId { get; set; }
        public int ProductPersonId { get; set; }
        public int TypeId { get; set; }
        public string ContactValue { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual ProductPerson ProductPerson { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<ContactPersonUse> ContactPersonUses { get; set; }
    }
}
