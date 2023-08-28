using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    public partial class DistributionView
    {
        public int? RegRequestId { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public DateTime? CreationTime { get; set; }
        public string RegistrationNumber { get; set; }
        public bool? IsIts { get; set; }
        public DateTime? ItsEndDate { get; set; }
        public int? ItsAgentId { get; set; }
        public bool? ItsRequerid { get; set; }
        public bool? IsAuto { get; set; }
        public bool? ItsExpired { get; set; }
        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public bool? IsCompetencyCenter { get; set; }
        public int? SaleCenterId { get; set; }
        public int? ItsSaleCenterId { get; set; }
        public bool? IsItsProf { get; set; }
        public string Distributor { get; set; }
        public string ItsPartner { get; set; }
        public string RegionName { get; set; }
    }
}
