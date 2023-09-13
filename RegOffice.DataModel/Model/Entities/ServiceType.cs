using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            CertificateServices = new HashSet<CertificateService>();
            RegRequestServices = new HashSet<RegRequestService>();
            ServiceBalanceDetails = new HashSet<ServiceBalanceDetail>();
            Services = new HashSet<Service>();
            WorkflowServices = new HashSet<WorkflowService>();
        }

        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public int ServiceModeId { get; set; }

        public virtual ServiceMode ServiceMode { get; set; }
        public virtual ICollection<CertificateService> CertificateServices { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
        public virtual ICollection<ServiceBalanceDetail> ServiceBalanceDetails { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
