using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Выпуски КЦР
    /// </summary>
    public partial class KcrIssue
    {
        public int IssueId { get; set; }
        public Guid? IssueGuid { get; set; }
        public int RegRequestId { get; set; }
        public int? AbonentTypeId { get; set; }

        /// <summary>
        /// максимальное количество КЭП
        /// </summary>
        public int MaxAmount { get; set; }

        /// <summary>
        /// выпущенное количество КЭП
        /// </summary>
        public int IssuedAmount { get; set; }

        /// <summary>
        /// дата истечения срока действия договора
        /// </summary>
        public DateOnly? SignExpiryDate { get; set; }
        public int? SignSectionId { get; set; }
        public int? SignTariffId { get; set; }

        /// <summary>
        /// id тарифа на выпуск КЭП
        /// </summary>
        public Guid? SignPriceTariffGuid { get; set; }

        /// <summary>
        /// id тарифа на подключение КЦР
        /// </summary>
        public Guid? KcrPriceTariffGuid { get; set; }

        /// <summary>
        /// выпуск открыт
        /// </summary>
        public bool IsActive { get; set; }
        public string SignArticle { get; set; }
        public int? SignTariffDiscountId { get; set; }
        public string KcrArticle { get; set; }

        /// <summary>
        /// криптопровайдер
        /// </summary>
        public int? CryptoProviderId { get; set; }
        public DateOnly? KcrExpiryDate { get; set; }
        public int? KcrTariffDiscountId { get; set; }
        public decimal? Price { get; set; }

        public virtual AbonentType AbonentType { get; set; }
        public virtual Provider CryptoProvider { get; set; }
        public virtual RegRequest RegRequest { get; set; }
        public virtual PriceTariff Sign { get; set; }
        public virtual TariffDiscount SignTariffDiscount { get; set; }
    }
}
