using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class WorkflowDocType
    {
        public int WorkflowDocTypeId { get; set; }
        public int WorkflowTypeId { get; set; }
        public int AbonentTypeId { get; set; }
        public int DocTypeId { get; set; }
        public bool Required { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual DocType DocType { get; set; }
        public virtual WorkflowType WorkflowType { get; set; }
    }
}
