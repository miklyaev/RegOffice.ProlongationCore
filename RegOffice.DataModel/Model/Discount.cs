using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица скидок
    /// </summary>
    public partial class Discount
    {
        public Discount()
        {
            AgentBalanceDetailChangeRequests = new HashSet<AgentBalanceDetailChangeRequest>();
            ContractTariffDiscounts = new HashSet<ContractTariffDiscount>();
            OfdDiscounts = new HashSet<OfdDiscount>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            TariffDiscounts = new HashSet<TariffDiscount>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Тип скидки
        /// </summary>
        public int DiscountTypeId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string DiscountName { get; set; }

        /// <summary>
        /// Относительная/абсолютная
        /// </summary>
        public bool? Percent { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public decimal? DiscountValue { get; set; }

        /// <summary>
        /// Минимальное значение
        /// </summary>
        public decimal? MinValue { get; set; }

        /// <summary>
        /// Максимальное значение
        /// </summary>
        public decimal? MaxValue { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }

        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? OffTime { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual ICollection<AgentBalanceDetailChangeRequest> AgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<ContractTariffDiscount> ContractTariffDiscounts { get; set; }
        public virtual ICollection<OfdDiscount> OfdDiscounts { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<TariffDiscount> TariffDiscounts { get; set; }
    }
}
