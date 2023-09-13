using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class DssApp
    {
        public DssApp()
        {
            DssAppSystems = new HashSet<DssAppSystem>();
            DssUserApps = new HashSet<DssUserApp>();
            RegRequestMemberDssApps = new HashSet<RegRequestMemberDssApp>();
        }

        public int AppId { get; set; }
        public string AppName { get; set; }

        public virtual ICollection<DssAppSystem> DssAppSystems { get; set; }
        public virtual ICollection<DssUserApp> DssUserApps { get; set; }
        public virtual ICollection<RegRequestMemberDssApp> RegRequestMemberDssApps { get; set; }
    }
}
