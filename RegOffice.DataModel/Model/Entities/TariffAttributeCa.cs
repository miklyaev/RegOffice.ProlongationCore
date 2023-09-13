using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RegOffice.DataModel.Model.Entities
{
    public partial class TariffAttributeCa
    {
        public int TariffAttributeId { get; set; }
        public int CaId { get; set; }
        public bool IsDefault { get; set; }
        public int? CaTemplateId { get; set; }
        public int TariffAttributeCaId { get; set; }

        public virtual Ca Ca { get; set; }
        public virtual CaTemplate CaTemplate { get; set; }
        public virtual TariffAttribute TariffAttribute { get; set; }
    }
}
