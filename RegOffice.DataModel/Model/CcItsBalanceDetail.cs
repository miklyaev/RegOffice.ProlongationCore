using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class CcItsBalanceDetail
    {

        /// <summary>
        /// Идентификатор баланса
        /// </summary>
        public int BalanceId { get; set; }

        /// <summary>
        /// Идентификатор абонента
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Идентификатор тарифа по договору
        /// </summary>
        public int ContractTariffId { get; set; }

        /// <summary>
        /// Сумма вознаграждения
        /// </summary>
        public decimal SumReward { get; set; }

        /// <summary>
        /// Позиция по вознаграждению за ИТС
        /// </summary>
        public bool? IsIts { get; set; }

        public virtual Abonent Abonent { get; set; }
        public virtual CcItsBalance Balance { get; set; }
        public virtual ContractTariff ContractTariff { get; set; }
    }
}
