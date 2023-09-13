using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class UnitType
    {
        public UnitType()
        {
            Units = new HashSet<Unit>();
        }

        public int UnitTypeId { get; set; }
        public string UnitTypeName { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}
