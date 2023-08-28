using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ProductPersonHistoryActionType
    {
        public ProductPersonHistoryActionType()
        {
            ProductPersonHistories = new HashSet<ProductPersonHistory>();
        }

        public int ActionTypeId { get; set; }
        public string ActionName { get; set; }

        public virtual ICollection<ProductPersonHistory> ProductPersonHistories { get; set; }
    }
}
