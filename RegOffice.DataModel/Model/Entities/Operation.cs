using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Operation
    {
        public Operation()
        {
            OperationLogs = new HashSet<OperationLog>();
        }

        public int OperationId { get; set; }
        public string OperationName { get; set; }

        public virtual ICollection<OperationLog> OperationLogs { get; set; }
    }
}
