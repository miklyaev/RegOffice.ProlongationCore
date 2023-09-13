using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestContact
    {
        public RegRequestContact()
        {
            RegRequestContactUses = new HashSet<RegRequestContactUse>();
        }

        public int ContactId { get; set; }
        public int RegRequestId { get; set; }
        public int TypeId { get; set; }
        public string ContactValue { get; set; }

        public virtual RegRequest RegRequest { get; set; }
        public virtual ContactType Type { get; set; }
        public virtual ICollection<RegRequestContactUse> RegRequestContactUses { get; set; }
    }
}
