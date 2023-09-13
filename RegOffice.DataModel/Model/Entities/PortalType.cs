using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PortalType
    {
        public PortalType()
        {
            PortalAccounts = new HashSet<PortalAccount>();
            RegRequestAccounts = new HashSet<RegRequestAccount>();
        }

        public int PortalTypeId { get; set; }
        public string PortalTypeName { get; set; }

        public virtual ICollection<PortalAccount> PortalAccounts { get; set; }
        public virtual ICollection<RegRequestAccount> RegRequestAccounts { get; set; }
    }
}
