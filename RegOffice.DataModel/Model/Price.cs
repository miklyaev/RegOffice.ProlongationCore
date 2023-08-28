using System;
using System.Collections.Generic;

namespace RegOffice.DataModel.Model
{
    /// <summary>
    /// Таблица прайсов
    /// </summary>
    public partial class Price
    {
        public Price()
        {
            AgentSchemes = new HashSet<AgentScheme>();
            PriceDiscountSteps = new HashSet<PriceDiscountStep>();
            PriceDiscounts = new HashSet<PriceDiscount>();
            PriceSections = new HashSet<PriceSection>();
            TariffZones = new HashSet<TariffZone>();
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PriceId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string PriceName { get; set; }

        /// <summary>
        /// Группа
        /// </summary>
        public int PriceGroupId { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }

        public virtual PriceGroup PriceGroup { get; set; }
        public virtual ICollection<AgentScheme> AgentSchemes { get; set; }
        public virtual ICollection<PriceDiscountStep> PriceDiscountSteps { get; set; }
        public virtual ICollection<PriceDiscount> PriceDiscounts { get; set; }
        public virtual ICollection<PriceSection> PriceSections { get; set; }
        public virtual ICollection<TariffZone> TariffZones { get; set; }
    }
}
