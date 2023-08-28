using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица логов изменений статусов кодов аутентификации
    /// </summary>
    public partial class DssAuthKeyStep
    {

        /// <summary>
        /// Идентификатор кода аутентификации
        /// </summary>
        public int DssAuthKeyId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual DssAuthKey DssAuthKey { get; set; }
        public virtual Step Step { get; set; }
    }
}
