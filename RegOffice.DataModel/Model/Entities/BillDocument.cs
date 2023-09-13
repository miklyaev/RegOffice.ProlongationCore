using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BillDocument
    {
        public int BillDocumentId { get; set; }
        public int? BillId { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public decimal? PaidSum { get; set; }
        public Guid? PaymentGuid { get; set; }
        public int? DocumentId { get; set; }

        public virtual SendedBill Bill { get; set; }
        public virtual BillDocumentType DocumentType { get; set; }
    }
}
