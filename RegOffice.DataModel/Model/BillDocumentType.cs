using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
