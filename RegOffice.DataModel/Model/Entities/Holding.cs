using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Holding
    {
        public int ParentAbonentId { get; set; }
        public int AbonentId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? OffTime { get; set; }
        public int HoldingId { get; set; }

        public virtual HoldingAbonent Abonent { get; set; }
        public virtual HoldingAbonent ParentAbonent { get; set; }
    }
}
