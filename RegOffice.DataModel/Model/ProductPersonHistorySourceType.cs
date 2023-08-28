using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
