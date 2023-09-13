using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BillDocumentType
    {
        public BillDocumentType()
        {
            BillDocuments = new HashSet<BillDocument>();
        }

        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }

        public virtual ICollection<BillDocument> BillDocuments { get; set; }
    }
}
