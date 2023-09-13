using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OperationLog
    {
        public int OperationLogId { get; set; }
        public int OperationId { get; set; }
        public int ApplicationId { get; set; }
        public int? UserId { get; set; }
        public DateTime RunTime { get; set; }
        public Guid? ProductGuid { get; set; }
        public string Note { get; set; }

        public virtual Application Application { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual User User { get; set; }
    }
}
