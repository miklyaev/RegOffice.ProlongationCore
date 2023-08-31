using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица членов группы компаний
    /// </summary>
    public partial class CompanyGroupAbonent
    {

        /// <summary>
        /// Группа компаний
        /// </summary>
        public int CompanyGroupId { get; set; }

        /// <summary>
        /// Компания
        /// </summary>
        public int AbonentId { get; set; }
    }
}
