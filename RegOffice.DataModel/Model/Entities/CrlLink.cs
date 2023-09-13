using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CrlLink
    {
        public int CrlLinkId { get; set; }
        public int CrlId { get; set; }
        public string Link { get; set; }

        public virtual Crl Crl { get; set; }
    }
}
