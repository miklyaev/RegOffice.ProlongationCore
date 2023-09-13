using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CaServiceType
    {
        public CaServiceType()
        {
            CaServices = new HashSet<CaService>();
        }

        public int CaServiceTypeId { get; set; }
        public string CaServiceTypeName { get; set; }

        public virtual ICollection<CaService> CaServices { get; set; }
    }
}
