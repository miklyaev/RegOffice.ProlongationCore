using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица типов услуг.
    /// </summary>
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


        /// <summary>
        /// Идентификатор типа услуги
        /// </summary>
        public int ServiceTypeId { get; set; }

        /// <summary>
        /// Наименование типа услуги
        /// </summary>
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// Режим
        /// </summary>
        public int ServiceModeId { get; set; }

        public virtual ServiceMode ServiceMode { get; set; }
        public virtual ICollection<CertificateService> CertificateServices { get; set; }
        public virtual ICollection<RegRequestService> RegRequestServices { get; set; }
        public virtual ICollection<ServiceBalanceDetail> ServiceBalanceDetails { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<WorkflowService> WorkflowServices { get; set; }
    }
}
