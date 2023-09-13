using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPersonHistorySourceType
    {
        public ProductPersonHistorySourceType()
        {
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
        }

        public int SourceTypeId { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
    }
}
