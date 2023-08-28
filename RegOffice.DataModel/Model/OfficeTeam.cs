using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Команды
    /// </summary>
    public partial class OfficeTeam
    {
        public OfficeTeam()
        {
            OfficeTeamPeople = new HashSet<OfficeTeamPerson>();
            RegRequestTeams = new HashSet<RegRequestTeam>();
        }


        /// <summary>
        /// Идентификатор команды
        /// </summary>
        public int OfficeTeamId { get; set; }

        /// <summary>
        /// Офис команды
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual ICollection<OfficeTeamPerson> OfficeTeamPeople { get; set; }
        public virtual ICollection<RegRequestTeam> RegRequestTeams { get; set; }
    }
}
