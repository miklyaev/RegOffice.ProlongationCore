using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Point
    {
        public Point()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            PointSteps = new HashSet<PointStep>();
            PointUses = new HashSet<PointUse>();
            PointZones = new HashSet<PointZone>();
            Products = new HashSet<Product>();
            RegRequestIdentPoints = new HashSet<RegRequest>();
            RegRequestTransferPoints = new HashSet<RegRequest>();
        }

        public int PointId { get; set; }
        public string PointName { get; set; }
        public Guid PointGuid { get; set; }
        public int AgentId { get; set; }
        public int? AddressId { get; set; }
        public string Schedule { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Note { get; set; }
        public int StepId { get; set; }

        public virtual Addr Address { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<PointStep> PointSteps { get; set; }
        public virtual ICollection<PointUse> PointUses { get; set; }
        public virtual ICollection<PointZone> PointZones { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RegRequest> RegRequestIdentPoints { get; set; }
        public virtual ICollection<RegRequest> RegRequestTransferPoints { get; set; }
    }
}
