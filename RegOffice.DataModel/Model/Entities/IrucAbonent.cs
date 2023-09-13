using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class IrucAbonent
    {
        public int IrucAbonentId { get; set; }
        public Guid AbonentGuid { get; set; }
        public string SystemPrefix { get; set; }
        public string EmailLogin { get; set; }
        public string DomainSoed { get; set; }
        public string EmailPassword { get; set; }
    }
}
