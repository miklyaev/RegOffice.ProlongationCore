using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class OfficeTeamPerson
    {
        public int PersonId { get; set; }
        public int OfficeTeamId { get; set; }
        public string PersonName { get; set; }

        public virtual OfficeTeam OfficeTeam { get; set; }
    }
}
