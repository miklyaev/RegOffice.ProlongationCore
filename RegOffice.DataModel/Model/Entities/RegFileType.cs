using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegFileType
    {
        public RegFileType()
        {
            ProductPeople = new HashSet<ProductPerson>();
            RegRequestMembers = new HashSet<RegRequestMember>();
        }

        public int RegFileTypeId { get; set; }
        public string RegFileTypeName { get; set; }

        public virtual ICollection<ProductPerson> ProductPeople { get; set; }
        public virtual ICollection<RegRequestMember> RegRequestMembers { get; set; }
    }
}
