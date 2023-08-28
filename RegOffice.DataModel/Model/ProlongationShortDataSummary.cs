using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class ProlongationShortDataSummary
    {

        /// <summary>
        /// Идентификатор статистики по партенрам
        /// </summary>
        public int SummaryId { get; set; }

        /// <summary>
        /// Идентификатор офиса
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Просрочено
        /// </summary>
        public int? Expired { get; set; }

        /// <summary>
        /// Заканчивается в этом месяце
        /// </summary>
        public int? ExpiredInThisMonth { get; set; }

        /// <summary>
        /// Заканчивается в следующем месяце
        /// </summary>
        public int? ExpiredInNextMonth { get; set; }

        /// <summary>
        /// Группа риска
        /// </summary>
        public int? RiskGroup { get; set; }

        /// <summary>
        /// Срочное продление
        /// </summary>
        public int? ProlongateImmediate { get; set; }

        /// <summary>
        /// Отключена проверка отправок
        /// </summary>
        public int? DisabledDispatchCount { get; set; }

        public virtual Office Office { get; set; }
    }
}
