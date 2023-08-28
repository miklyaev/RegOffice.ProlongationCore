using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class HoldingAbonent
    {
        public HoldingAbonent()
        {
            HoldingAbonents = new HashSet<Holding>();
            HoldingParentAbonents = new HashSet<Holding>();
        }


        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Время отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Ид
        /// </summary>
        public int AbonentId { get; set; }

        /// <summary>
        /// Ид партнёра 1С
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; }

        public virtual ICollection<Holding> HoldingAbonents { get; set; }
        public virtual ICollection<Holding> HoldingParentAbonents { get; set; }
    }
}
