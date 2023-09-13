using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MerchandiseGroupType
    {
        public MerchandiseGroupType()
        {
            MerchandiseGroups = new HashSet<MerchandiseGroup>();
        }

        public int MerchandiseGroupTypeId { get; set; }
        public string MerchandiseGroupTypeName { get; set; }

        public virtual ICollection<MerchandiseGroup> MerchandiseGroups { get; set; }
    }
}
