using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RoutePfr
    {
        public RoutePfr()
        {
            InverseRoutePfr1Navigation = new HashSet<RoutePfr>();
        }

        public string PfrCode { get; set; }
        public string RoutePfr1 { get; set; }
        public string LayoutPfr { get; set; }
        public int FileMaskId { get; set; }

        public virtual FileMask FileMask { get; set; }
        public virtual RoutePfr RoutePfr1Navigation { get; set; }
        public virtual ICollection<RoutePfr> InverseRoutePfr1Navigation { get; set; }
    }
}
