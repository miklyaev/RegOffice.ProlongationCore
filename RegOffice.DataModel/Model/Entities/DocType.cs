using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DocType
    {
        public DocType()
        {
            AttributeDocumentTypes = new HashSet<AttributeDocumentType>();
            Docs = new HashSet<Doc>();
            OfficeDocTypes = new HashSet<OfficeDocType>();
            WorkflowDocTypes = new HashSet<WorkflowDocType>();
        }

        public int DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public string DocTypeAlias { get; set; }

        public virtual ICollection<AttributeDocumentType> AttributeDocumentTypes { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
        public virtual ICollection<OfficeDocType> OfficeDocTypes { get; set; }
        public virtual ICollection<WorkflowDocType> WorkflowDocTypes { get; set; }
    }
}
