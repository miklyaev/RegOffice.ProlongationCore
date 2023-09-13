﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentUserRegion
    {
        public int RegionId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual Region Region { get; set; }
        public virtual User User { get; set; }
    }
}
