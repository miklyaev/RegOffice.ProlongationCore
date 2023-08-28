using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний лицензий в пуле
    /// </summary>
    public partial class LicensePoolStep
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

        public virtual LicensePool License { get; set; }
        public virtual Step Step { get; set; }
    }
}
