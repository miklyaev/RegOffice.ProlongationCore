using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class Holding
    {

        /// <summary>
        /// Головная организация
        /// </summary>
        public int ParentAbonentId { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public int AbonentId { get; set; }

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
        public int HoldingId { get; set; }

        public virtual HoldingAbonent Abonent { get; set; }
        public virtual HoldingAbonent ParentAbonent { get; set; }
    }
}
