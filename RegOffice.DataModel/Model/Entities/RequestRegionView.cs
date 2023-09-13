using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class RequestRegionView
    {
        public int? RegRequestId { get; set; }
        public int? RegionId { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? CompetencyCenterId { get; set; }
        public string CompetencyCenterName { get; set; }
        public int? NormalizedPartnerId { get; set; }
        public string NormalizedPartnerName { get; set; }
    }
}
