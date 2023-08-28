using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Заявки, одобренные командами
    /// </summary>
    public partial class RegRequestTeam
    {

        /// <summary>
        /// Заявка
        /// </summary>
        public int RegRequestId { get; set; }

        /// <summary>
        /// Команда
        /// </summary>
        public int OfficeTeamId { get; set; }

        public virtual OfficeTeam OfficeTeam { get; set; }
        public virtual RegRequest RegRequest { get; set; }
    }
}
