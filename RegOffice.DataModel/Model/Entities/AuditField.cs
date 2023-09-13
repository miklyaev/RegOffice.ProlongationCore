using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AuditField
    {
        public DateTime CreationTime { get; set; }
        public string UserName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string PkName { get; set; }
        public string PkValue { get; set; }
        public char Action { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
    }
}
