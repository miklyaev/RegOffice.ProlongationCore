using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SendedBill
    {
        public SendedBill()
        {
            AgentBalanceBills = new HashSet<AgentBalanceBill>();
            BillDocuments = new HashSet<BillDocument>();
            MerchandiseBills = new HashSet<MerchandiseBill>();
            OfdPins = new HashSet<OfdPin>();
            Orders = new HashSet<Order>();
            SkziLicenses = new HashSet<SkziLicense>();
        }

        public int? AgentFromId { get; set; }
        public int? AgentToId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string BillNumber { get; set; }
        public bool? PaidFor { get; set; }
        public int BillId { get; set; }
        public Guid? BillGuid { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? BillTotalSum { get; set; }
        public decimal? BillNdsSum { get; set; }
        public int? AbonentId { get; set; }
        public decimal BillPayedSum { get; set; }
        public bool IsSent { get; set; }
        public int? InvoiceReturnTypeId { get; set; }
        public DateTime? CancelTime { get; set; }
        public DateTime? BlockTime { get; set; }
        public string Notice { get; set; }
        public int? DocumentId { get; set; }
        public Guid? WalletGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Agent AgentFrom { get; set; }
        public virtual Agent AgentTo { get; set; }
        public virtual InvoiceReturnType InvoiceReturnType { get; set; }
        public virtual BillDocumentStock BillDocumentStock { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<BillDocument> BillDocuments { get; set; }
        public virtual ICollection<MerchandiseBill> MerchandiseBills { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
