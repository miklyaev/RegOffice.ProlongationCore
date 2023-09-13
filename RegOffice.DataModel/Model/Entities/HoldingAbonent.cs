using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class HoldingAbonent
    {
        public HoldingAbonent()
        {
            HoldingAbonents = new HashSet<Holding>();
            HoldingParentAbonents = new HashSet<Holding>();
        }

        public DateTime CreationTime { get; set; }
        public DateTime? OffTime { get; set; }
        public int AbonentId { get; set; }
        public string AgentId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }

        public virtual ICollection<Holding> HoldingAbonents { get; set; }
        public virtual ICollection<Holding> HoldingParentAbonents { get; set; }
    }
}
