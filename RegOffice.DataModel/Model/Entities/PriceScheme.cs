using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class PriceScheme
    {
        public int RegionId { get; set; }
        public int TariffZoneId { get; set; }
        public int ProductTypeId { get; set; }
        public int? CompetenceCenterId { get; set; }
        public int? LeadOfficeId { get; set; }

        public virtual Office CompetenceCenter { get; set; }
        public virtual Office LeadOffice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Region Region { get; set; }
        public virtual TariffZone TariffZone { get; set; }
    }
}
