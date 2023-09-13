using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CcItsBalanceDetail
    {
        public int BalanceId { get; set; }
        public int AbonentId { get; set; }
        public int ContractTariffId { get; set; }
        public decimal SumReward { get; set; }
        public bool? IsIts { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual CcItsBalance Balance { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
    }
}
