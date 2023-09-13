using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductPersonHistory
    {
        public DateTime ActionTime { get; set; }
        public int? UserId { get; set; }
        public int ProductPersonId { get; set; }
        public int ProductPersonHistoryId { get; set; }
        public int? RegRequestId { get; set; }
        public int? ActionTypeId { get; set; }
        public int? SourceId { get; set; }

        public virtual ProductPersonHistoryActionType ActionType { get; set; }
        public virtual ProductPerson ProductPerson { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual ProductPersonHistorySourceType Source { get; set; }
        public virtual User User { get; set; }
    }
}
