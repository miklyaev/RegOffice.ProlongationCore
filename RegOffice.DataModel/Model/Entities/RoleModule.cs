﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RoleModule
    {
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public DateTime CreationTime { get; set; }
        public int AccessLevelId { get; set; }

        public virtual AccessLevel AccessLevel { get; set; }
        public virtual Module Module { get; set; }
        public virtual Role Role { get; set; }
    }
}
