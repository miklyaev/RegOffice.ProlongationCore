using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class LogExtendedDetail
    {
        public int LogDetailId { get; set; }
        public int LogId { get; set; }
        public string FieldName { get; set; }
        public int? OldInt { get; set; }
        public string OldString { get; set; }
        public bool? OldBool { get; set; }
        public DateTime? OldDatetime { get; set; }
        public int? NewInt { get; set; }
        public string NewString { get; set; }
        public bool? NewBool { get; set; }
        public DateTime? NewDatetime { get; set; }

        public virtual LogExtended Log { get; set; }
    }
}
