using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class BonusType
    {
        public BonusType()
        {
            Bonus = new HashSet<Bonus>();
        }

        public int BonusTypeId { get; set; }
        public string BonusTypeName { get; set; }

        public virtual ICollection<Bonus> Bonus { get; set; }
    }
}
