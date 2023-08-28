using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class LogV222
    {
        public Guid LogId { get; set; }
        public int LogTypeId { get; set; }
        public int ApplicationId { get; set; }
        public string LogMessage { get; set; }
        public int? LogCode { get; set; }
        public DateTime LogTime { get; set; }
        public string AppInstance { get; set; }

        public virtual Application Application { get; set; }
        public virtual LogType LogType { get; set; }
    }
}
