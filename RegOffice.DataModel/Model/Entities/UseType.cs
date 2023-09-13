using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UseType
    {
        public UseType()
        {
            ContactPersonUses = new HashSet<ContactPersonUse>();
            ContactUses = new HashSet<ContactUse>();
            ReflexUseTypes = new HashSet<ReflexUseType>();
            RegRequestContactUses = new HashSet<RegRequestContactUse>();
            RegRequestMemberContactUses = new HashSet<RegRequestMemberContactUse>();
        }

        public int UseTypeId { get; set; }
        public string UseTypeName { get; set; }

        public virtual ICollection<ContactPersonUse> ContactPersonUses { get; set; }
        public virtual ICollection<ContactUse> ContactUses { get; set; }
        public virtual ICollection<ReflexUseType> ReflexUseTypes { get; set; }
        public virtual ICollection<RegRequestContactUse> RegRequestContactUses { get; set; }
        public virtual ICollection<RegRequestMemberContactUse> RegRequestMemberContactUses { get; set; }
    }
}
