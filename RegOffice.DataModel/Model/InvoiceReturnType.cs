using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class InvoiceReturnType
    {
        public InvoiceReturnType()
        {
            SendedBills = new HashSet<SendedBill>();
        }

        public int InvoiceReturnTypeId { get; set; }
        public string InvoiceReturnTypeName { get; set; }

        public virtual ICollection<SendedBill> SendedBills { get; set; }
    }
}
