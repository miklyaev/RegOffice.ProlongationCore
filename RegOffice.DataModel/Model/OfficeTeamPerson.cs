using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Участники команды
    /// </summary>
    public partial class OfficeTeamPerson
    {

        /// <summary>
        /// Идентификатор участника
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Команда
        /// </summary>
        public int OfficeTeamId { get; set; }

        /// <summary>
        /// Фамилия участника
        /// </summary>
        public string PersonName { get; set; }

        public virtual OfficeTeam OfficeTeam { get; set; }
    }
}
