using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AuditData
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string UserName { get; set; }
        public DateTime CreationTime { get; set; }
        public string Action { get; set; }
        public string OriginalData { get; set; }
        public string NewData { get; set; }
        public string Query { get; set; }
    }
}
