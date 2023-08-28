using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class BillDocument
    {
        public int BillDocumentId { get; set; }
        public int? BillId { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Сумма платежа
        /// </summary>
        public decimal? PaidSum { get; set; }

        /// <summary>
        /// Идентификатор платежа
        /// </summary>
        public Guid? PaymentGuid { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public int? DocumentId { get; set; }

        public virtual SendedBill Bill { get; set; }
        public virtual BillDocumentType DocumentType { get; set; }
    }
}
