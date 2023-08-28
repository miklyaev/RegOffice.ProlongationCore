using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний лицензий
    /// </summary>
    public partial class LicenseStep
    {

        /// <summary>
        /// Лицензия
        /// </summary>
        public int LicenseId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual License License { get; set; }
        public virtual Step Step { get; set; }
        public virtual User User { get; set; }
    }
}
