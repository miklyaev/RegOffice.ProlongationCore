using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ChildAgentsView
    {
        public int? AgentId { get; set; }
        public string AgentName { get; set; }
        public int? LevelId { get; set; }
        public int? SaleCenterId { get; set; }
        public string SaleCenterName { get; set; }
        public int? CompetentionCenterId { get; set; }
        public string CompetentionCenterName { get; set; }
    }
}
