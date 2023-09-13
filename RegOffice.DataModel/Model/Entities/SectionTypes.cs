using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class SectionTypes
    {
        public SectionTypes()
        {
            Documents = new HashSet<Documents>();
        }

        public int EnumId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
    }
}
