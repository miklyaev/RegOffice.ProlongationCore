using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
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
