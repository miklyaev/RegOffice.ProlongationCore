﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RegRequestMemberEku
    {
        public int RegRequestMemberId { get; set; }
        public int EkuId { get; set; }

        public virtual Eku Eku { get; set; }
        public virtual RegRequestMember RegRequestMember { get; set; }
    }
}
