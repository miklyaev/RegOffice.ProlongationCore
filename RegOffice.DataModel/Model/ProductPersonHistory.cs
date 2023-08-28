using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
