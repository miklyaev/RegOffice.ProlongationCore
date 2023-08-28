using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
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
