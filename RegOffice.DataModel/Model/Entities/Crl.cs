using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Crl
    {
        public Crl()
        {
            CrlLinks = new HashSet<CrlLink>();
        }

        public int CrlId { get; set; }
        public string AuthorityKeyId { get; set; }
        public int FileId { get; set; }
        public DateTime ThisUpdate { get; set; }
        public DateTime NextUpdate { get; set; }
        public DateTime? ProcessingDate { get; set; }

        public virtual ICollection<CrlLink> CrlLinks { get; set; }
    }
}
