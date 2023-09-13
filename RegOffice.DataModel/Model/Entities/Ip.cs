using System;
using System.Collections.Generic;
using System.Net;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Ip
    {
        public int IpId { get; set; }
        public IPAddress IpAddress { get; set; }
        public int ServerId { get; set; }

        public virtual Server Server { get; set; }
    }
}
