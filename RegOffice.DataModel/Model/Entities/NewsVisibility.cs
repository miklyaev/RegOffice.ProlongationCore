using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class NewsVisibility
    {
        public int NewsVisibilityId { get; set; }
        public int NewsId { get; set; }
        public int? RegionId { get; set; }
        public int? AgentId { get; set; }
        public int? RoleId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? AgentLevelId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual AgentLevel AgentLevel { get; set; }
        public virtual News News { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Role Role { get; set; }
    }
}
