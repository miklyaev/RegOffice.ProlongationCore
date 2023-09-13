using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssAuthSystem
    {
        public DssAuthSystem()
        {
            DssAppSystems = new HashSet<DssAppSystem>();
            DssAuths = new HashSet<DssAuth>();
        }

        public int AuthSystemId { get; set; }
        public int MethId { get; set; }
        public string SystemAlias { get; set; }
        public string SystemId { get; set; }
        public int DssId { get; set; }
        public bool IsDefault { get; set; }

        public virtual Dss Dss { get; set; }
        public virtual DssAuthMeth Meth { get; set; }
        public virtual ICollection<DssAppSystem> DssAppSystems { get; set; }
        public virtual ICollection<DssAuth> DssAuths { get; set; }
    }
}
