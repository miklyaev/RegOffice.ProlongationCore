using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegionStatistic
    {
        public string RegionName { get; set; }
        public long? ItsCount { get; set; }
        public long? CountFull { get; set; }
        public decimal? Cf { get; set; }
        public bool? Success { get; set; }
        public long? CountWeek { get; set; }
        public decimal? Price { get; set; }
    }
}
