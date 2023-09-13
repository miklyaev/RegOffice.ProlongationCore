using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PropType
    {
        public PropType()
        {
            PropDicts = new HashSet<PropDict>();
        }

        public int PropTypeId { get; set; }
        public string PropTypeName { get; set; }

        public virtual ICollection<PropDict> PropDicts { get; set; }
    }
}
