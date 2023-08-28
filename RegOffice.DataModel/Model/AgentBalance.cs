using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Ежемесячные сверки между партнером и Центром продаж
    /// </summary>
    public partial class AgentBalance
    {
        public AgentBalance()
        {
            AgentBalanceBills = new HashSet<AgentBalanceBill>();
            AgentBalanceDetails = new HashSet<AgentBalanceDetail>();
            AgentBalanceOffices = new HashSet<AgentBalanceOffice>();
        }


        /// <summary>
        /// Идентификатор сверки
        /// </summary>
        public int BalanceId { get; set; }

        /// <summary>
        /// Год сверки
        /// </summary>
        public int BalanceYear { get; set; }

        /// <summary>
        /// Месяц сверки
        /// </summary>
        public int BalanceMonth { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Дата, когда сверка стала не одобреной
        /// </summary>
        public DateTime LastUnacceptDate { get; set; }

        /// <summary>
        /// Дата одобрения сверки партнером
        /// </summary>
        public DateTime? PartnerAcceptDate { get; set; }

        /// <summary>
        /// Дата одобрения сверки Центром продаж
        /// </summary>
        public DateTime? SaleCenterAcceptDate { get; set; }

        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }

        /// <summary>
        /// Дата одобрения сверки АО
        /// </summary>
        public DateTime? MercuryAcceptDate { get; set; }

        /// <summary>
        /// % вознаграждения агента Астрал-отчёт
        /// </summary>
        public decimal? MercuryAgentPercentReward { get; set; }

        /// <summary>
        /// % вознаграждения ЦП Астрал-отчёт
        /// </summary>
        public decimal? MercuryScPercentReward { get; set; }

        /// <summary>
        /// Дата одобрения сверки ЭТП партнёром
        /// </summary>
        public DateTime? EtpAcceptDate { get; set; }

        /// <summary>
        /// Дата одобрения сверки ЭТП ЦП
        /// </summary>
        public DateTime? EtpScAcceptDate { get; set; }

        /// <summary>
        /// Дата одобрения вендором
        /// </summary>
        public DateTime? EtpVendorAcceptDate { get; set; }

        /// <summary>
        /// ЦП
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// % вознаграждения агента ЭТП
        /// </summary>
        public decimal? EtpAgentPercentReward { get; set; }

        /// <summary>
        /// Дата одобрения счетов 1СО
        /// </summary>
        public DateTime? BillAcceptDate { get; set; }

        /// <summary>
        /// Дата одобрения счета ОФД
        /// </summary>
        public DateTime? OfdBillAcceptDate { get; set; }

        /// <summary>
        /// Дата одобрения счета ЭТП(Астрал-ЭТ)
        /// </summary>
        public DateTime? EtpBillAcceptDate { get; set; }

        /// <summary>
        /// % вознаграждения агента АО5
        /// </summary>
        public decimal? Ao5AgentPercentReward { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual ICollection<AgentBalanceBill> AgentBalanceBills { get; set; }
        public virtual ICollection<AgentBalanceDetail> AgentBalanceDetails { get; set; }
        public virtual ICollection<AgentBalanceOffice> AgentBalanceOffices { get; set; }
    }
}
