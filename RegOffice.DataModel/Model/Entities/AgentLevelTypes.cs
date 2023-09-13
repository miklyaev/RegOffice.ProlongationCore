using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class AgentLevelTypes
    {
        public AgentLevelTypes()
        {
            Agents = new HashSet<Agents>();
        }

        public int EnumId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Agents> Agents { get; set; }
    }
}
