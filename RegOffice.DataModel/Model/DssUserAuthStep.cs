using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица состояний мобильной аутентификации пользователей DSS
    /// </summary>
    public partial class DssUserAuthStep
    {
        public int Id { get; set; }

        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int DssUserId { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public int? AuthStepId { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual Step AuthStep { get; set; }
        public virtual DssUser DssUser { get; set; }
    }
}
