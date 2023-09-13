using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LogV223
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
