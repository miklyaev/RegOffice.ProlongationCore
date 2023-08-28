using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица регионов пользователей для потенциальных клиентов
    /// </summary>
    public partial class PotentialAbonentUserRegion
    {

        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual Region Region { get; set; }
        public virtual User User { get; set; }
    }
}
