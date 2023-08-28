using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class RequestWithoutPartnerView
    {
        public int? RegRequestId { get; set; }
        public int? RegionId { get; set; }
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public int? CompetencyCenterId { get; set; }
        public string CompetencyCenterName { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? NormalizedPartnerId { get; set; }
        public string NormalizedPartnerName { get; set; }
    }
}
