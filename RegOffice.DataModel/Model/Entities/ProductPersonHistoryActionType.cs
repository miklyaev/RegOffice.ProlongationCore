using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
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
