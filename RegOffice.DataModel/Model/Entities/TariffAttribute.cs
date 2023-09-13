using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffAttribute
    {
        public TariffAttribute()
        {
            TariffAttributeCas = new HashSet<TariffAttributeCa>();
            TariffAttributeLimits = new HashSet<TariffAttributeLimit>();
        }

        public int TariffId { get; set; }
        public int AttributeId { get; set; }
        public int? Number { get; set; }
        public int? MinNumber { get; set; }
        public int? MaxNumber { get; set; }
        public int? IndexNumber { get; set; }
        public int? MinIndex { get; set; }
        public int? LimitId { get; set; }
        public int? Validity { get; set; }
        public int? ValidityUnitId { get; set; }
        public int? WaitingDays { get; set; }
        public int TariffAttributeId { get; set; }
        public int? MaxIndex { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Limit Limit { get; set; }
        public virtual Tariff Tariff { get; set; }
        public virtual Unit ValidityUnit { get; set; }
        public virtual TradingPlatformTariffAttribute TradingPlatformTariffAttribute { get; set; }
        public virtual ICollection<TariffAttributeCa> TariffAttributeCas { get; set; }
        public virtual ICollection<TariffAttributeLimit> TariffAttributeLimits { get; set; }
    }
}
