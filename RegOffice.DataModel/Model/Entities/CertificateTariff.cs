using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class CertificateTariff
    {
        public CertificateTariff()
        {
            CertificateTariffSteps = new HashSet<CertificateTariffStep>();
        }

        public int CertificateTariffId { get; set; }
        public int CertificateId { get; set; }
        public int ProductId { get; set; }
        public int AgentId { get; set; }
        public decimal Price { get; set; }
        public decimal PercentDiscount { get; set; }
        public decimal DiscountSum { get; set; }
        public decimal Sum { get; set; }
        public int StepId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual Product Product { get; set; }
        public virtual Step Step { get; set; }
        public virtual ICollection<CertificateTariffStep> CertificateTariffSteps { get; set; }
    }
}
