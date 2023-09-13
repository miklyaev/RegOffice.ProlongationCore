using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BonusScheme
    {
        public int SchemeId { get; set; }
        public int BonusId { get; set; }

        public virtual Bonus Bonus { get; set; }
        public virtual AgentScheme Scheme { get; set; }
    }
}
