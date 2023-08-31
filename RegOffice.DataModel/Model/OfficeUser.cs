using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица связи пользователей с офисами
    /// </summary>
    public partial class OfficeUser
    {

        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
    }
}
