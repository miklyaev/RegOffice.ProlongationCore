using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PotentialAbonentUcb
    {
        public int PotentialAbonentId { get; set; }
        public DateTime? UcbTransferDate { get; set; }
        public int? UcbUserId { get; set; }
        public string CertNumber { get; set; }

        public virtual PotentialAbonent PotentialAbonent { get; set; }
        public virtual User UcbUser { get; set; }
    }
}
