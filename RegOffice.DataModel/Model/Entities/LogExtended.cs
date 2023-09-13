using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LogExtended
    {
        public LogExtended()
        {
            LogExtendedDetails = new HashSet<LogExtendedDetail>();
        }

        public int LogId { get; set; }
        public int UserId { get; set; }
        public int EntityId { get; set; }
        public string TableName { get; set; }
        public int LogTypeId { get; set; }
        public DateTime LogTime { get; set; }
        public int OperationId { get; set; }

        public virtual LogType LogType { get; set; }
        public virtual LogExtendedOperationDesc Operation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<LogExtendedDetail> LogExtendedDetails { get; set; }
    }
}
