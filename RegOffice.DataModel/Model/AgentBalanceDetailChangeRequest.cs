using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Заявки на изменение позиции сверки
    /// </summary>
    public partial class AgentBalanceDetailChangeRequest
    {
        public AgentBalanceDetailChangeRequest()
        {
            AgentBalanceDetailChangeRequestComments = new HashSet<AgentBalanceDetailChangeRequestComment>();
            AgentBalanceDetailChangeRequestSteps = new HashSet<AgentBalanceDetailChangeRequestStep>();
        }


        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }

        /// <summary>
        /// Позиция в сверке, по которой пришло заявление на изменение
        /// </summary>
        public int BalanceDetailId { get; set; }

        /// <summary>
        /// Цена, указанная в сверке
        /// </summary>
        public decimal StartPrice { get; set; }

        /// <summary>
        /// Цена, которую предлагает Партнер или ЦП
        /// </summary>
        public decimal? RequestPrice { get; set; }

        /// <summary>
        /// Цена, утверждённая Вендором
        /// </summary>
        public decimal? FinalPrice { get; set; }

        /// <summary>
        /// Флаг запроса на удаление позиции
        /// </summary>
        public bool ToDelete { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public int? DiscountId { get; set; }

        /// <summary>
        /// Пользователь, подавший заявку на изменение позиции
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Время последнего обновления заявки
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Время создания заявки
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual AgentBalanceDetail BalanceDetail { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestComment> AgentBalanceDetailChangeRequestComments { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequestStep> AgentBalanceDetailChangeRequestSteps { get; set; }
    }
}
