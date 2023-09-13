using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ProductTransferLog
    {
        public ProductTransferLog()
        {
            TransferTariffLogs = new HashSet<TransferTariffLog>();
        }

        public int ProductTransferId { get; set; }
        public int ProductId { get; set; }
        public DateTime LogTime { get; set; }
        public int OfficeId { get; set; }
        public int PreviousOfficeId { get; set; }
        public int UserId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Office PreviousOffice { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransferTariffLog> TransferTariffLogs { get; set; }
    }
}
