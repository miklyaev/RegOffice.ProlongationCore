using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class MerchandiseType
    {
        public MerchandiseType()
        {
            Merchandises = new HashSet<Merchandise>();
        }

        public int MerchandiseTypeId { get; set; }
        public string MerchandiseTypeName { get; set; }

        public virtual ICollection<Merchandise> Merchandises { get; set; }
    }
}
