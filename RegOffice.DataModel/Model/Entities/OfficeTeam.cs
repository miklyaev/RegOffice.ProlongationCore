using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfficeTeam
    {
        public OfficeTeam()
        {
            OfficeTeamPeople = new HashSet<OfficeTeamPerson>();
            RegRequestTeams = new HashSet<RegRequestTeam>();
        }

        public int OfficeTeamId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual ICollection<OfficeTeamPerson> OfficeTeamPeople { get; set; }
        public virtual ICollection<RegRequestTeam> RegRequestTeams { get; set; }
    }
}
