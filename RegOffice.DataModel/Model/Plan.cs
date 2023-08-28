using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// План подключений абонентов
    /// </summary>
    public partial class Plan
    {
        public Plan()
        {
            PlanDetails = new HashSet<PlanDetail>();
            Schemes = new HashSet<AgentScheme>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PlanId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PlanName { get; set; }

        public virtual ICollection<PlanDetail> PlanDetails { get; set; }
        public virtual ICollection<AgentScheme> Schemes { get; set; }
    }
}
