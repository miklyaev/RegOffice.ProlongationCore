using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица условий
    /// </summary>
    public partial class Condition
    {
        public Condition()
        {
            Transitions = new HashSet<Transition>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ConditionId { get; set; }

        /// <summary>
        /// ГУИД условия
        /// </summary>
        public Guid ConditionGuid { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
