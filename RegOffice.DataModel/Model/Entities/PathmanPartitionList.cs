using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PathmanPartitionList
    {
        public int? Parttype { get; set; }
        public string Expr { get; set; }
        public string RangeMin { get; set; }
        public string RangeMax { get; set; }
    }
}
