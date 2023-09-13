using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class KcrIssue
    {
        public int IssueId { get; set; }
        public Guid? IssueGuid { get; set; }
        public int RegRequestId { get; set; }
        public int? AbonentTypeId { get; set; }
        public int MaxAmount { get; set; }
        public int IssuedAmount { get; set; }
        public DateTime? SignExpiryDate { get; set; }
        public int? SignSectionId { get; set; }
        public int? SignTariffId { get; set; }
        public Guid? SignPriceTariffGuid { get; set; }
        public Guid? KcrPriceTariffGuid { get; set; }
        public bool IsActive { get; set; }
        public string SignArticle { get; set; }
        public int? SignTariffDiscountId { get; set; }
        public string KcrArticle { get; set; }
        public int? CryptoProviderId { get; set; }
        public DateTime? KcrExpiryDate { get; set; }
        public int? KcrTariffDiscountId { get; set; }
        public decimal? Price { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Provider CryptoProvider { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual PriceTariff Sign { get; set; }
        public virtual TariffDiscount SignTariffDiscount { get; set; }
    }
}
