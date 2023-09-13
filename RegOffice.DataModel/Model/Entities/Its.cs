using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class Its
    {
        public Its()
        {
            ItsAdditionalItsChildren = new HashSet<ItsAdditional>();
            ItsAdditionalItsParents = new HashSet<ItsAdditional>();
            ItsHistories = new HashSet<ItsHistory>();
            LicenseDetails = new HashSet<LicenseDetail>();
        }

        public int ItsId { get; set; }
        public string ItsInn { get; set; }
        public string ItsKpp { get; set; }
        public string ItsName { get; set; }
        public DateTime? ItsStartDate { get; set; }
        public DateTime? ItsEndDate { get; set; }
        public string ItsPublishName { get; set; }
        public int? ItsPublishCount { get; set; }
        public bool? ItsPaid { get; set; }
        public string RegistrationNumber { get; set; }
        public int? AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentInn { get; set; }
        public string AgentKpp { get; set; }
        public string Distributor { get; set; }
        public string Locality { get; set; }
        public int? RegionId { get; set; }
        public string DistributorInn { get; set; }
        public string DistributorKpp { get; set; }
        public DateTime? OffTime { get; set; }
        public DateTime? ItsCreationDate { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<ItsAdditional> ItsAdditionalItsChildren { get; set; }
        public virtual ICollection<ItsAdditional> ItsAdditionalItsParents { get; set; }
        public virtual ICollection<ItsHistory> ItsHistories { get; set; }
        public virtual ICollection<LicenseDetail> LicenseDetails { get; set; }
    }
}
