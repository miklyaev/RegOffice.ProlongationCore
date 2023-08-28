using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Выставленные счета
    /// </summary>
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


        /// <summary>
        /// Агент который выставляет счет
        /// </summary>
        public int? AgentFromId { get; set; }

        /// <summary>
        /// Агент которому выставляется счет
        /// </summary>
        public int? AgentToId { get; set; }

        /// <summary>
        /// Дата создания заявки на счет
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Номер счета
        /// </summary>
        public string BillNumber { get; set; }

        /// <summary>
        /// Оплачено или нет
        /// </summary>
        public bool? PaidFor { get; set; }

        /// <summary>
        /// Ид счета
        /// </summary>
        public int BillId { get; set; }
        public Guid? BillGuid { get; set; }

        /// <summary>
        /// Дата счета
        /// </summary>
        public DateTime? BillDate { get; set; }

        /// <summary>
        /// Полная сумма счета (включая НДС)
        /// </summary>
        public decimal? BillTotalSum { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        public decimal? BillNdsSum { get; set; }
        public int? AbonentId { get; set; }
        public decimal BillPayedSum { get; set; }
        public bool IsSent { get; set; }
        public int? InvoiceReturnTypeId { get; set; }

        /// <summary>
        /// Дата аннулирования счета
        /// </summary>
        public DateTime? CancelTime { get; set; }

        /// <summary>
        /// Дата блокировки
        /// </summary>
        public DateTime? BlockTime { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Notice { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        public int? DocumentId { get; set; }

        /// <summary>
        /// Ид. кошелька
        /// </summary>
        public Guid? WalletGuid { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual Agent AgentFrom { get; set; }
        public virtual Agent AgentTo { get; set; }
        public virtual InvoiceReturnType InvoiceReturnType { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<BillDocument> BillDocuments { get; set; }
        public virtual ICollection<MerchandiseBill> MerchandiseBills { get; set; }
        public virtual ICollection<OfdPin> OfdPins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SkziLicense> SkziLicenses { get; set; }
    }
}
