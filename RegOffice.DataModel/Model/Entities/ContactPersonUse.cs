using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ContactPersonUse
    {
        public int ContactPersonId { get; set; }
        public int TypeId { get; set; }
        public bool? Main { get; set; }

        public virtual ContactPerson ContactPerson { get; set; }
        public virtual UseType Type { get; set; }
    }
}
