using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MerchandiseGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? ParentId { get; set; }
        public string GroupCid { get; set; }
        public int? MerchandiseGroupTypeId { get; set; }

        public virtual MerchandiseGroupType MerchandiseGroupType { get; set; }
    }
}
