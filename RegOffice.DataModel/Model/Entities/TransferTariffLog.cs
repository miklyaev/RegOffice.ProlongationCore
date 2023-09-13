using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TransferTariffLog
    {
        public int TransferTariffId { get; set; }
        public int ProductTransferId { get; set; }
        public int ContractTariffId { get; set; }
        public int PreviousContractTariffId { get; set; }

        public virtual ContractTariff ContractTariff { get; set; }
        public virtual ContractTariff PreviousContractTariff { get; set; }
        public virtual ProductTransferLog ProductTransfer { get; set; }
    }
}
