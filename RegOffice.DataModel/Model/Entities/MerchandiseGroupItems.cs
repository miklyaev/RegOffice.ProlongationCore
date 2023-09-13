using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MerchandiseGroupItems
    {
        public int? GroupId { get; set; }
        public int? MerchandiseId { get; set; }
        public bool IsRequired { get; set; }

        public virtual MerchandiseGroup Group { get; set; }
        public virtual Merchandise Merchandise { get; set; }
    }
}
