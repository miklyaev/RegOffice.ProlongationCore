using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LogType
    {
        public LogType()
        {
            LogExtendeds = new HashSet<LogExtended>();
            LogV222s = new HashSet<LogV222>();
            LogV223s = new HashSet<LogV223>();
            LogV2s = new HashSet<LogV2>();
            Logs = new HashSet<Log>();
        }

        public int LogTypeId { get; set; }
        public string LogTypeName { get; set; }

        public virtual ICollection<LogExtended> LogExtendeds { get; set; }
        public virtual ICollection<LogV222> LogV222s { get; set; }
        public virtual ICollection<LogV223> LogV223s { get; set; }
        public virtual ICollection<LogV2> LogV2s { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
