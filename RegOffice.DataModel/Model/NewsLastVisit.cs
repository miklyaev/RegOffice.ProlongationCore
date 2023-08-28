using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class NewsLastVisit
    {

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Дата последнего посещения вкладки новостей
        /// </summary>
        public DateTime LastVisitDate { get; set; }
    }
}
