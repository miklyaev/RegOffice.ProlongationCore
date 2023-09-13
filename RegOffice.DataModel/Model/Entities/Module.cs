using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Module
    {
        public Module()
        {
            ModuleTariffs = new HashSet<ModuleTariff>();
            RoleModules = new HashSet<RoleModule>();
        }

        public int ModuleId { get; set; }
        public int? ProductTypeId { get; set; }
        public string MuduleName { get; set; }
        public DateTime CreationTime { get; set; }
        public int TypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ModuleType Type { get; set; }
        public virtual ICollection<ModuleTariff> ModuleTariffs { get; set; }
        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
