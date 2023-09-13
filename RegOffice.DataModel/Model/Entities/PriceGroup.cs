using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceGroup
    {
        public PriceGroup()
        {
            Prices = new HashSet<Price>();
        }

        public int PriceGroupId { get; set; }
        public string PriceGroupName { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
    }
}
