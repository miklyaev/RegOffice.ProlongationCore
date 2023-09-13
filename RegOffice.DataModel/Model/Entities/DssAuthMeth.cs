﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuthMeth
    {
        public DssAuthMeth()
        {
            DssAuthSystems = new HashSet<DssAuthSystem>();
        }

        public int MethId { get; set; }
        public string Description { get; set; }
        public int? AuthOrder { get; set; }

        public virtual ICollection<DssAuthSystem> DssAuthSystems { get; set; }
    }
}
