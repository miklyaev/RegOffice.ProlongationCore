using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LogExtendedOperationDesc
    {
        public LogExtendedOperationDesc()
        {
            LogExtendeds = new HashSet<LogExtended>();
        }

        public int OperationId { get; set; }
        public string OperationDescription { get; set; }

        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
    }
}
